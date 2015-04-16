﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICT4Events_S24_Groep_E
{
    public partial class InschrijfForm : Form
    {
        // Fields
        private Administratie administratie;
        private List<Plaats> geselecteerdePlaatsen;
        private Hoofdboeker hoofdboeker;

        public InschrijfForm()
        {
            InitializeComponent();
            administratie = new Administratie();
            geselecteerdePlaatsen = new List<Plaats>();
            VulComboBox();
        }

        // Event Handlers
        private void btnMaakBezoeker_Click(object sender, EventArgs e)
        {
            if(tbNaam.Text != "" && tbWachtwoord.Text != "" && tbRekNr.Text != "" && tbNaam.Text != "" && tbAchternaam.Text != "")
            {
                if(geselecteerdePlaatsen.Count == 0)
                {
                    MessageBox.Show("Selecteer eerst een of meer plaatsen");
                }
                else
                {
                    hoofdboeker = new Hoofdboeker(tbGebruikersnaam.Text, tbWachtwoord.Text, dtpGebDatum.Value, tbRekNr.Text, tbNaam.Text, tbAchternaam.Text);
                    // hier wordt alleen gecheckt of de gebruikersnaam al bestaat of niet
                    // als dat zo is dan kan de hoofdboeker niet gemaakt worden.
                    if (administratie.HuidigEvent.CheckPersoon(hoofdboeker))
                    {
                        gbGegevens.Enabled = false;
                        gbPlaatsen.Enabled = false;
                        MessageBox.Show("Hoofdboeker Gemaakt");
                    }
                    else
                    {
                        MessageBox.Show("Gebruikersnaam bestaat al");
                    }
                }                               
            }
            else
            {
                MessageBox.Show("Niet alle gegevens juist ingevuld");
            }
        }

        private void btnVoegPlaatsToe_Click(object sender, EventArgs e)
        {
            if (cbPlaats.SelectedItem != null)
            {
                string plaats = cbPlaats.SelectedItem.ToString();
                Plaats gekozenPlaats = administratie.HuidigEvent.GeefPlaats(plaats.Substring(10, 4));
                if (!gekozenPlaats.Bezet)
                {
                    gekozenPlaats.Bezet = true;
                    geselecteerdePlaatsen.Add(gekozenPlaats);
                }
                else
                {
                    MessageBox.Show("Plaats is al gekozen");
                }
            }
            Ververs();
        }

        private void btnVerwijderPlaats_Click(object sender, EventArgs e)
        {
            if (lbPlaatsen.SelectedItem != null)
            {
                string plaats = lbPlaatsen.SelectedItem.ToString();
                Plaats gekozenPlaats = administratie.HuidigEvent.GeefPlaats(plaats.Substring(10, 4));
                geselecteerdePlaatsen.Remove(gekozenPlaats);
                gekozenPlaats.Bezet = false;
            }
            Ververs();
        }

        private void btnVolgende_Click(object sender, EventArgs e)
        {
            // checken of alle textboxen goed zijn aangemaakt, 
            // hieruit kan de hoofdboeker gemaakt worden, met bijbehorende reservering

            // als alles is ingevuld wordt de bezoeker ook daadwerkelijk aangemaakt
            // dit kan als de gebruiker van het programma op volgende klikt of dat
            // de gebruiker op huurmateriaal klikt.
            if (hoofdboeker != null)
            {
                if (!chbMeerPersonen.Checked)
                {
                    DialogResult andereBezoekers = MessageBox.Show("Weet u zeker of u geen andere bezoekers wilt inschrijven? \n Klik anders op de checkbox voor meerdere personen.", "Error", MessageBoxButtons.YesNo);
                    if (andereBezoekers == DialogResult.Yes)
                    {
                        // hoofdboeker wordt definitief gemaakt
                        // programma moet terugkeren naar het inlogform
                        administratie.HuidigEvent.VoegPersoonToe(hoofdboeker);
                        MessageBox.Show("Inschrijving afgerond");
                        // als de beheerder op bevestigen drukt dan moet hij terug naar systeemkiezerform gaan.
                        // als dit een gewone persoon is dan hoeft er niets te gebeuren.
                        this.Dispose(); 
                        BijFormClosen();
                                            
                    }
                    // als de gebruiker op nee klikt dan moet het programma niets doen.
                }
                else
                {
                    if (cbMeerderePersonen.SelectedItem != null)
                    {
                        // Hoofdboeker wordt definitief gemaakt
                        // programma gaat door naar volgende bezoekers
                        administratie.HuidigEvent.VoegPersoonToe(hoofdboeker);
                        administratie.HuidigEvent.Reserveringen.Add(new Reservering(hoofdboeker, geselecteerdePlaatsen)); // nieuwe reservering wordt aan het evenement toegevoegd.
                        InschrijfFormBezoeker inschrijfformBezoeker = new InschrijfFormBezoeker((int)cbMeerderePersonen.SelectedItem, hoofdboeker);
                        inschrijfformBezoeker.Show();
                        this.Dispose();
                    }
                }
            }
            else
            {
                MessageBox.Show("Maak eerst een hoofdboeker");
            }
        }

        private void btnMateriaalHuren_Click(object sender, EventArgs e)
        {
            if (hoofdboeker != null)
            {
                MateriaalVerhuurForm MVF = new MateriaalVerhuurForm(hoofdboeker);
                MVF.Show();
            }
            else
            {
                MessageBox.Show("Maak eerst een hoofdboeker");
            }
        }

        private void chbMeerPersonen_CheckedChanged(object sender, EventArgs e)
        {
            if (chbMeerPersonen.Checked)
            {
                cbMeerderePersonen.Enabled = true;
                btnVolgende.Text = "Volgende";
            }
            else
            {
                cbMeerderePersonen.Enabled = false;
                cbMeerderePersonen.Items.Clear();
                btnVolgende.Text = "Bevestig";
            }
            Ververs();
        }

        // Methoden
        private void VulComboBox()
        {
            // nog kijken of een plaats al bezet is of niet.
            // alleen niet bezette plaatsen toevoegen!!!
            foreach (Plaats p in administratie.HuidigEvent.Plaatsen)
            {
                if (!p.Bezet)
                {
                    cbPlaats.Items.Add(p.ToString());
                }
            }
            if(cbPlaats.SelectedIndex != -1)
            {
                cbPlaats.SelectedIndex = 0;
            }
        }

        private void Ververs()
        {
            // De geselecteerde plaatsen komen in de listbox als ze verwijderd zijn gaan ze er weer uit.
            lbPlaatsen.Items.Clear();
            foreach (Plaats p in geselecteerdePlaatsen)
            {
                lbPlaatsen.Items.Add(p.ToString());
            }

            // cbMeerderePersonen wordt gevuld
            cbMeerderePersonen.Items.Clear();
            int personen = 1;
            foreach (Plaats p in geselecteerdePlaatsen)
            {
                personen += p.AantalPersonen;
            }
            for (int i = 1; i < personen; i++)
            {
                cbMeerderePersonen.Items.Add(i);
            }
            if (cbMeerderePersonen.SelectedIndex != -1)
            {
                cbMeerderePersonen.SelectedIndex = 0;
            }
        }

        private void btnAnnuleren_Click(object sender, EventArgs e)
        {
            hoofdboeker = null;
            gbGegevens.Enabled = true;
            gbPlaatsen.Enabled = true;
        }

        private void InschrijfForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Als de beheerder is ingelogd dan terug naar systeemkiezer
            // Als er geen beheerder is ingelogd dan niets doen want dan zit je niet ingelogd in de applicatie
            if(administratie.NuIngelogd is Beheerder)
            {
                var SysteemKiezer = new SysteemKiezerForm();
                SysteemKiezer.Show();
            }
            
        }

        private void BijFormClosen()
        {
            if (administratie.NuIngelogd is Beheerder)
            {
                var SysteemKiezer = new SysteemKiezerForm();
                SysteemKiezer.Show();
            }
        }



    }
}
