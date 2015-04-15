using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.ServiceProcess; <-- wtf is deze

namespace ICT4Events_S24_Groep_E
{
    public partial class EventBeheerForm : Form
    {
        System.Windows.Forms.Timer timer;
        int interval = 3000;
        //List<Event> events;
        List<Bezoeker> bezoekers;
        private Event evenement;
        bool shit = false;
        private Administratie administratie;


        public EventBeheerForm()
        {
            InitializeComponent();
            timer = new System.Windows.Forms.Timer();
            //events = new List<Event>();
            bezoekers = new List<Bezoeker>();
            administratie = new Administratie();
            evenement = administratie.HuidigEvent;
            refreshCbEvents();

            //enable gebruiker tab als user een admin is? rechten??
            if (shit) gbGebruikers.Enabled = true;
            btnNee.Enabled = false;
            btnZeker.Enabled = false;
            //getAlleEvents();
            //cbEventsEventbeheer.SelectedIndex = 0;
        }

        private void refreshCbEvents()
        {
            cbEvents.Items.Clear();
            foreach (Event ev in administratie.Events)
            {
                if (true) // voorwaarde
                {
                    cbEvents.Items.Add(ev.ToString());
                }
            }
            

            cbEventsEventbeheer.Items.Clear();
            /*foreach (Event e in administratie.Events)
            {
                cbEventsEventbeheer.Items.Add(e.Naam);
                cbEventsEventbeheer.SelectedIndex = 0;
            }*/
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
        #region not used
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnPasEventAan_Click(object sender, EventArgs e)
        {
            
        }
        #endregion

        private void btnVerwijderEvent_Click(object sender, EventArgs e)
        {
            foreach (Event ev in administratie.Events)
            {
                if (ev == evenement)
                {
                    administratie.Events.Remove(ev);
                    break;
                }
            }
        }

        private void btnMaakEventAan_Click(object sender, EventArgs e)
        {
            string naam = tbEventNaamEventbeheer.Text;
            string plaats = tbPlaatsEventbeheer.Text;
            string adres = tbAdresEventbeheer.Text;
            DateTime beginDatum = dtpBeginDatum.Value;
            DateTime eindDatum = dtpEindDatum.Value;
            if (administratie.VoegEventToe(naam, beginDatum, eindDatum, plaats, adres))
            {
                //getAlleEvents();
                updateEventTab();
            }
            
        }

        private void cbEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string itemselected = Convert.ToString(cbEvents.SelectedItem);
            foreach (Event ev in administratie.Events)
            {
                if (itemselected == ev.ToString())
                {
                    evenement = ev;
                    break;
                }
            }
            updateEventTab();
        }
        private void updateEventTab()
        {
            // alle events specs invullen.... moet uit de database
            dtpBeginDatum.Value = evenement.BeginDatum;
            dtpEindDatum.Value = evenement.EindDatum;
            tbEventNaam.Text = evenement.Naam;
            tbPlaatsEventbeheer.Text = evenement.Plaats;
            tbAdresEventbeheer.Text = evenement.Adres;
            // nu die cb updaten :|

            cbPlaats.SelectedValue = evenement.Plaats;
            foreach (Plaats p in evenement.Plaatsen)
            {
                cbPlaatsen.Items.Add(p.ToString());
            }

            
            dtpBeginDatum.Value = administratie.GeefEvent(cbEventsEventbeheer.Text).BeginDatum;
            dtpEindDatum.Value = administratie.GeefEvent(cbEventsEventbeheer.Text).EindDatum;
            tbEventNaamEventbeheer.Text = cbEventsEventbeheer.Text;
            tbPlaatsEventbeheer.Text = administratie.GeefEvent(cbEventsEventbeheer.Text).Plaats;
            tbAdresEventbeheer.Text = administratie.GeefEvent(cbEventsEventbeheer.Text).Adres;
        }

        private void btnInfoOpvraag_Click(object sender, EventArgs e)
        {
            string info = "Bezoekers informatie:" ;
            foreach (Persoon p in evenement.Personen)
            {
                if (p is Bezoeker)
                {
                    Bezoeker b = (Bezoeker)p;
                    info = p.Gebruikersnaam.ToString() + " - " + p.Naam.ToString() + " - " + p.GeboorteDatum.ToString() + " - " + p.Achternaam.ToString() + " - " + p.RfidCode.ToString();
                }
                    lbGebruikerinfo.Items.Add(info);
            }
        }

        private void updateCBs()
        {

            cbPlaats.Items.Clear();
            foreach (object ob in cbPlaats.Items)
            {
                if (true) // voorwaarde
                {
                    cbPlaats.Items.Add(ob.ToString());
                }
            }
        }

        private void TerugNaarLogIn(object sender, FormClosedEventArgs e)
        {
            var logInForm = new LoginForm();
            logInForm.Show();
        }

        private void btnDatabaseConnectie_Click(object sender, EventArgs e)
        {
            DatabaseKoppeling database = new DatabaseKoppeling();
            database.Koppel();
        }
    }
}
