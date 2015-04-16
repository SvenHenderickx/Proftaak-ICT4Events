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
            this.btnNee.Enabled = true;
            this.btnVerwijder.Enabled = false;

            timer.Interval = interval;
            timer.Tick += timer_Tick;
            timer.Start();
        }

        private void btnZeker_Click(object sender, EventArgs e)
        {
            this.btnNee.Enabled = false;
            this.btnZeker.Enabled = false;
        }

        private void btnNee_Click(object sender, EventArgs e)
        {
            this.btnNee.Enabled = false;
            this.btnZeker.Enabled = false;
            this.btnVerwijder.Enabled = true;
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

        private void btnMaakEventAan_Click(object sender, EventArgs e)
        {
            foreach (Event evenement in administratie.Events)
            {
                if (tbEventNaamEventbeheer.Text == evenement.Naam)
                {
                    MessageBox.Show("Er bestaat al een evenement met die naam.");
                }
                else
                {
                    string naam = tbEventNaamEventbeheer.Text;
                    string plaats = tbPlaatsEventbeheer.Text;
                    string adres = tbAdresEventbeheer.Text;
                    DateTime beginDatum = dtpBeginDatum.Value;
                    DateTime eindDatum = dtpEindDatum.Value;
                    if (administratie.VoegEventToe(naam, beginDatum, eindDatum, plaats, adres))
                    {
                        refreshCbEvents();
                        updateEventTab();
                    }
                    break;
                }
            }
            
            
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
        }

        private void btnInfoOpvraag_Click(object sender, EventArgs e)
        {
            string info = "Bezoekers informatie:" ;
            foreach (Persoon p in administratie.GeefEvent(cbEventsEventbeheer.Text).Personen)
            {
                if (p is Bezoeker)
                {
                    Bezoeker b = (Bezoeker)p;
                    info = 
                        p.Gebruikersnaam.ToString() + " - " + 
                        p.Naam.ToString()           + " - " + 
                        p.GeboorteDatum.ToString()  + " - " + 
                        p.Achternaam.ToString()     + " - " + 
                        p.RfidCode.ToString();
                }
                lbGebruikerinfo.Items.Add(info);
            }
        }

        private void TerugNaarLogIn(object sender, FormClosedEventArgs e)
        {
            var logInForm = new LoginForm();
            logInForm.Show();
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
            string teverwijderen = cbMateriaal.Text.Substring(0, cbMateriaal.Text.IndexOf(","));
            foreach (Huuritem h in administratie.GeefEvent(cbEventsEventbeheer.Text).HuurMateriaal)
            {
                if (h.Naam == teverwijderen)
                {
                    administratie.GeefEvent(cbEventsEventbeheer.Text).HuurMateriaal.Remove(h);
                    break;
                }
            }
            updateEventTab();
        }
    }
}
