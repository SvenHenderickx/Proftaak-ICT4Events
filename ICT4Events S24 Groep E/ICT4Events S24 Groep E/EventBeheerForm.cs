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
    public partial class EventBeheerForm : Form
    {
        //Fields
        DatabaseKoppeling database;
        System.Windows.Forms.Timer timer;
        int interval = 3000;
        private Administratie administratie;


        public EventBeheerForm()
        {
            InitializeComponent();
            timer = new System.Windows.Forms.Timer();
            administratie = new Administratie();
            refreshCbEvents();
            cbEventsEventbeheer.SelectedIndex = 0;
            gbGebruikers.Enabled = true;
            btnNee.Enabled = false;
            btnZeker.Enabled = false;
        }

        //Event Handlers
        //Deze methode refreshed de combobox cbEventsEventbeheer
        private void refreshCbEvents()
        {
            cbEventsEventbeheer.Items.Clear();
            foreach (Event ev in administratie.Events)
            {
                cbEventsEventbeheer.Items.Add(ev.Naam);
            }
            cbEventsEventbeheer.SelectedIndex = 0;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            btnZeker.Enabled = true;
            timer.Stop();
        }

        private void btnVerwijder_Click(object sender, EventArgs e)
        {
            if (lbGebruikerinfo.SelectedItem == null)
            {
                MessageBox.Show("Selecteer a.u.b. een gebruiker om te verwijderen.");
            }
            else
            {
                this.btnNee.Enabled = true;
                this.btnVerwijder.Enabled = false;
                lbGebruikerinfo.Enabled = false;
                timer.Interval = interval;
                timer.Tick += timer_Tick;
                timer.Start();
            }
            
        }

        private void btnZeker_Click(object sender, EventArgs e)
        {
            lbGebruikerinfo.Enabled = true;
            this.btnNee.Enabled = false;
            this.btnZeker.Enabled = false;
            btnVerwijder.Enabled = true;
            string verwijderen = lbGebruikerinfo.SelectedItem.ToString().Substring(0, lbGebruikerinfo.SelectedItem.ToString().IndexOf(","));
            foreach (Persoon p in administratie.GeefEvent(cbEventsEventbeheer.Text).Personen)
            {
                if (verwijderen == p.RfidCode)
                {
                    administratie.GeefEvent(cbEventsEventbeheer.Text).Personen.Remove(p);
                    break;
                }
            }
            updateEventTab();
        }

        private void btnNee_Click(object sender, EventArgs e)
        {
            this.btnNee.Enabled = false;
            this.btnZeker.Enabled = false;
            this.btnVerwijder.Enabled = true;
            lbGebruikerinfo.Enabled = true;
            timer.Stop();
        }
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnPasEventAan_Click(object sender, EventArgs e)
        {
            foreach (Event ev in administratie.Events)
            {
                if (ev == administratie.GeefEvent(cbEventsEventbeheer.Text))
                {
                    ev.Naam = tbEventNaamEventbeheer.Text;
                    ev.BeginDatum = dtpBeginDatum.Value;
                    ev.EindDatum = dtpEindDatum.Value;
                    ev.Plaats = tbPlaatsEventbeheer.Text;
                    ev.Adres = tbAdresEventbeheer.Text;
                    break;
                }
            }
            refreshCbEvents();
            updateEventTab();

        }

        private void btnVerwijderEvent_Click(object sender, EventArgs e)
        {
            if (cbEventsEventbeheer.Items.Count == 1)
            {
                MessageBox.Show("Dit is het laatste event!");
            }
            else
            {
                foreach (Event ev in administratie.Events)
                {
                    if (ev == administratie.GeefEvent(cbEventsEventbeheer.Text))
                    {
                        administratie.Events.Remove(ev);
                        break;
                    }
                }
                refreshCbEvents();
                updateEventTab();
            }
            
        }

        private void btnMaakEventAan_Click(object sender, EventArgs e)
        {
            if (administratie.VoegEventToe(tbEventNaamEventbeheer.Text, dtpBeginDatum.Value, dtpEindDatum.Value, tbPlaatsEventbeheer.Text, tbAdresEventbeheer.Text))
            {
                MessageBox.Show("Event succesvol toegevoegd");
            }
            else
            {
                MessageBox.Show("Er bestaat al een event met die naam.");
            }
            refreshCbEvents();
            updateEventTab();
        }

        private void cbEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateEventTab();
        }
        private void updateEventTab()
        {
            dtpBeginDatum.Value = administratie.GeefEvent(cbEventsEventbeheer.Text).BeginDatum;
            dtpEindDatum.Value = administratie.GeefEvent(cbEventsEventbeheer.Text).EindDatum;
            tbEventNaamEventbeheer.Text = administratie.GeefEvent(cbEventsEventbeheer.Text).Naam;
            tbPlaatsEventbeheer.Text = administratie.GeefEvent(cbEventsEventbeheer.Text).Plaats;
            tbAdresEventbeheer.Text = administratie.GeefEvent(cbEventsEventbeheer.Text).Adres;
            cbDeelnemersEventbeheer.Items.Clear();
            cbPlaatsen.Items.Clear();
            cbMateriaal.Items.Clear();
            lbGebruikerinfo.Items.Clear();
            lbHuidigMateriaal.Items.Clear();
            cbMateriaalToevoegen.SelectedIndex = 0;
            lbHuidigePlaatsen.Items.Clear();
            foreach (Persoon p in administratie.GeefEvent(cbEventsEventbeheer.Text).Personen)
            {
                if (p is Bezoeker)
                {
                    cbDeelnemersEventbeheer.Items.Add(p.Naam + " " + p.Achternaam + ", " + p.RfidCode);
                    cbDeelnemersEventbeheer.SelectedIndex = 0;
                }
            }
            foreach (Plaats p in administratie.GeefEvent(cbEventsEventbeheer.Text).Plaatsen)
            {
                cbPlaatsen.Items.Add(p.PlaatsNummer);
                cbPlaatsen.SelectedIndex = 0;
            }
            foreach (Huuritem h in administratie.GeefEvent(cbEventsEventbeheer.Text).HuurMateriaal)
            {
                cbMateriaal.Items.Add(h.Naam +", "  + h.Type);
                cbMateriaal.SelectedIndex = 0;
            }

            foreach (Persoon p in administratie.GeefEvent(cbEventsEventbeheer.Text).Personen)
            {
                if (p is Bezoeker)
                {
                    Bezoeker b = p as Bezoeker;
                    string info = p.RfidCode + ", " + p.Naam + " " + p.Achternaam + ", " + p.Gebruikersnaam + ", " + administratie.GeefPlaats(b, administratie.GeefEvent(cbEventsEventbeheer.Text));
                    lbGebruikerinfo.Items.Add(info);

                }
            }
            foreach (Huuritem h in administratie.GeefEvent(cbEventsEventbeheer.Text).HuurMateriaal)
            {
                string status;
                if (h.IsGehuurd)
                {
                    status = "Gehuurd";
                }
                else
                {
                    status = "Niet gehuurd";
                }
                
                string toevoegen = h.Naam + ", " + h.Type + ", " + status + "\n";
                lbHuidigMateriaal.Items.Add(toevoegen);
            }
            foreach (Plaats p in administratie.GeefEvent(cbEventsEventbeheer.Text).Plaatsen)
            {
                if (p.Huurder != null)
                {
                    string info = p.PlaatsNummer + ", " + p.AantalPersonen + " personen, " + p.Huurder.Gebruikersnaam + ", € " + p.Prijs;
                    lbHuidigePlaatsen.Items.Add(info);
                }
                else
                {
                    string info = p.PlaatsNummer + ", " + p.AantalPersonen + " personen, " + "Niet verhuurd, " + "€ " + p.Prijs;
                    lbHuidigePlaatsen.Items.Add(info);
                }
                
            }
        }

        private void TerugNaarLogIn(object sender, FormClosedEventArgs e)
        {
            var Systeemkiezer = new SysteemKiezerForm();
            Systeemkiezer.Show();
        }

        private void btnDatabaseConnectie_Click(object sender, EventArgs e)
        {
            database = new DatabaseKoppeling();
            database.Koppel(); 
        }

        private void buttonVerwijderPlaatsen_Click(object sender, EventArgs e)
        {
            foreach (Plaats p in administratie.GeefEvent(cbEventsEventbeheer.Text).Plaatsen)
            {
                if (p.PlaatsNummer.ToString() == cbPlaatsen.Text)
                {
                    administratie.GeefEvent(cbEventsEventbeheer.Text).Plaatsen.Remove(p);
                    break;
                }
            }
            updateEventTab();
        }

        private void buttonVerwijderMateriaal_Click(object sender, EventArgs e)
        {
            if (cbMateriaal.Text != "")
            {
                string teverwijderen = cbMateriaal.Text.Substring(0, cbMateriaal.Text.IndexOf(","));
                foreach (Huuritem h in administratie.GeefEvent(cbEventsEventbeheer.Text).HuurMateriaal)
                {
                    if (h.Naam == teverwijderen)
                    {
                        administratie.GeefEvent(cbEventsEventbeheer.Text).HuurMateriaal.Remove(h);
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show("Er is geen materiaal om te verwijderen.");
            }
            updateEventTab();
        }

        private void buttonVoegMateriaalToe_Click(object sender, EventArgs e)
        {
            if(cbMateriaalToevoegen.Text != "" && tbMateriaalToevoegen.Text != "")
            {
                administratie.GeefEvent(cbEventsEventbeheer.Text).HuurMateriaal.Add(new Huuritem(tbMateriaalToevoegen.Text, cbMateriaalToevoegen.Text));
            }
            else
            {
                MessageBox.Show("Geef a.u.b. een soort en naam");
            }
            updateEventTab();
        }

        private void buttonVoegPlaatsToe_Click(object sender, EventArgs e)
        {
            if (tbPlaatsToevoegenPrijs.Text != "" && administratie.IsDigitsOnly(tbPlaatsToevoegenPrijs.Text))
            {
                administratie.GeefEvent(cbEventsEventbeheer.Text).Plaatsen.Add(new Plaats(Convert.ToInt32(tbPlaatsToevoegenPrijs.Text), null, chkPlaatsGeluidoverlast.ThreeState, Convert.ToInt32(nudPlaatsPersonen.Value)));
            }
            else
            {
                MessageBox.Show("Voer a.u.b. een geldig getal in zonder decimalen");
            }
            updateEventTab();
        }
    }
}
