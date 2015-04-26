using System;
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
        // dit gaat voortaan via gekozenplaatsen
        private List<Plaats> geselecteerdePlaatsen;
        private Hoofdboeker hoofdboeker;
        private DatabaseKoppeling dbKoppeling;
        private List<string> gekozenplaatsen;

        public InschrijfForm()
        {
            InitializeComponent();
            administratie = new Administratie();
            geselecteerdePlaatsen = new List<Plaats>();
            dbKoppeling = new DatabaseKoppeling();
            gekozenplaatsen = new List<string>();
            VulComboBox();
        }

        // Event Handlers
        private void btnMaakBezoeker_Click(object sender, EventArgs e)
        {
            if(tbNaam.Text != "" && tbWachtwoord.Text != "" && tbRekNr.Text != "" && tbNaam.Text != "" && tbAchternaam.Text != "")
            {
                if (tbWachtwoord.Text != tbWachtWoordConfirm.Text)
                {
                    MessageBox.Show("Wachtwoorden komen niet overeen. \n Controleer uw wachtwoord nogmaals.");
                }
                else
                {
                    // geselecteerdeplaatsen = gekozenplaatsen
                    if (gekozenplaatsen.Count == 0)
                    {
                        MessageBox.Show("Selecteer eerst een of meer plaatsen.");
                    }
                    else
                    {
                        hoofdboeker = new Hoofdboeker(tbGebruikersnaam.Text, tbWachtwoord.Text, dtpGebDatum.Value, tbRekNr.Text, tbNaam.Text, tbAchternaam.Text, administratie.RfidGenerator(), false);
                        // deze hoofdboeker moet ook een reserverings_id mee krijgen. daarna wordt er per plaats het reserverings id toegekent. 

                        // hier wordt alleen gecheckt of de gebruikersnaam al bestaat of niet
                        // als dat zo is dan kan de hoofdboeker niet gemaakt worden.
                        if (administratie.HuidigEvent.CheckPersoon(hoofdboeker))
                        {
                            gbGegevens.Enabled = false;
                            gbPlaatsen.Enabled = false;
                            MessageBox.Show("Hoofdboeker is aangemaakt.");
                        }
                        else
                        {
                            MessageBox.Show("De ingevoerde gebruikersnaam bestaat al. \n Voer een andere in.");
                        }
                    }
                }                              
            }
            else
            {
                MessageBox.Show("Niet alle gegevens zijn juist ingevuld.");
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
                    // plaats ook in de database bezetten.
                    dbKoppeling.BezetPlaats(plaats.Substring(10, 4));
                    gekozenplaatsen.Add(gekozenPlaats.PlaatsNummer);
                }
                else
                {
                    MessageBox.Show("Deze plaats is al gekozen. Kies een andere.");
                }
            }
            //Ververs();
            Verversen();
        }

        private void btnVerwijderPlaats_Click(object sender, EventArgs e)
        {
            if (lbPlaatsen.SelectedItem != null)
            {
                string plaats = lbPlaatsen.SelectedItem.ToString();
                Plaats gekozenPlaats = administratie.HuidigEvent.GeefPlaats(plaats.Substring(10, 4));
                gekozenPlaats.Bezet = false;
                geselecteerdePlaatsen.Remove(gekozenPlaats);
                gekozenplaatsen.Remove(gekozenPlaats.PlaatsNummer);
                dbKoppeling.OnBezetPlaats(plaats.Substring(10, 4));
                
            }
            //Ververs();
            Verversen();
        }

        private void btnVolgende_Click(object sender, EventArgs e)
        {
            // checken of alle textboxen goed zijn aangemaakt, 
            //// hieruit kan de hoofdboeker gemaakt worden, met bijbehorende reservering

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
                        MessageBox.Show("Inschrijving afgerond.");
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
                        // voeg nu persoon toe aan database
                        administratie.HuidigEvent.Reserveringen.Add(new Reservering(hoofdboeker, geselecteerdePlaatsen)); // nieuwe reservering wordt aan het evenement toegevoegd.
                        // er wordt een nieuwe reservering aangemaakt en hier hoort ook een persoon bij.
                        InschrijfFormBezoeker inschrijfformBezoeker = new InschrijfFormBezoeker((int)cbMeerderePersonen.SelectedItem, hoofdboeker);
                        inschrijfformBezoeker.Show();
                        this.Dispose();
                    }
                }
            }
            else
            {
                MessageBox.Show("Maak eerst een hoofdboeker aan.");
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
                MessageBox.Show("Maak eerst een hoofdboeker aan.");
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
            //Ververs();
            Verversen();
        }

        // Methoden
        private void VulComboBox()
        {
            // nog kijken of een plaats al bezet is of niet.
            // alleen niet bezette plaatsen toevoegen!!!
            foreach (Plaats p in dbKoppeling.HaalPlaatsenOp(administratie.HuidigEvent.Naam))
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

        // deze methode werkte voor de databaseconnectie
        private void Ververs()
        {
            // De geselecteerde plaatsen komen in de listbox als ze verwijderd zijn gaan ze er weer uit.
            lbPlaatsen.Items.Clear();
            foreach (Plaats p in geselecteerdePlaatsen)
            {
                lbPlaatsen.Items.Add(p.ToString());
                lblPrijsTotaal.Text = (Convert.ToInt32(lblPrijsTotaal.Text) + p.Prijs).ToString();
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

        private void Verversen()
        {
            // De geselecteerde plaatsen komen in de listbox als ze verwijderd zijn gaan ze er weer uit.
            lbPlaatsen.Items.Clear();
            foreach (String s in gekozenplaatsen)
            {
                Plaats p = administratie.HuidigEvent.GeefPlaats(s);
                lbPlaatsen.Items.Add(p.ToString());
                lblPrijsTotaal.Text = (Convert.ToInt32(lblPrijsTotaal.Text) + p.Prijs).ToString();
            }

            // cbMeerderePersonen wordt gevuld
            cbMeerderePersonen.Items.Clear();
            int personen = 1;
            foreach (String s in gekozenplaatsen)
            {
                Plaats p = administratie.HuidigEvent.GeefPlaats(s);
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
            // als een hoofdboeker geannuleerd wordt dan wordt ook zijn bijbehorende materiaal verwijderd en weer beschikbaar.
            if(hoofdboeker != null)
            {
                hoofdboeker.LeegMateriaal(hoofdboeker);
                hoofdboeker = null;
            }     
            gbGegevens.Enabled = true;
            gbPlaatsen.Enabled = true;
            //maak dit voor meer dan alleen sme !!!


            // hij staat alleen hierbij om te testen!!!
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
