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
        Administratie admin;
        System.Windows.Forms.Timer timer;
        int interval = 3000;
        //List<Event> events;
        List<Bezoeker> bezoekers;
        private Event evenement;
        bool shit = false;


        public EventBeheerForm()
        {
            InitializeComponent();
            admin = new Administratie();
            timer = new System.Windows.Forms.Timer();
            //events = new List<Event>();
            bezoekers = new List<Bezoeker>();
            Administratie administratie = new Administratie();
            evenement = administratie.HuidigEvent;
            refreshCbEvents();

            //enable gebruiker tab als user een admin is? rechten??
            if (shit) gbGebruikers.Enabled = true;
        }

        private void refreshCbEvents()
        {
            cbEvents.Items.Clear();
            foreach (Event ev in admin.Events)
            {
                if (true) // voorwaarde
                {
                    cbEvents.Items.Add(ev.ToString());
                }
            }
            

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
            foreach (Event ev in admin.Events)
            {
                if (ev == evenement)
                {
                    admin.Events.Remove(ev);
                    break;
                }
            }
        }

        private void btnMaakEventAan_Click(object sender, EventArgs e)
        {
            string naam = tbEventNaam.Text,
                plaats = cbPlaatsen.SelectedIndex.ToString(),
                adres=cbAdresSelecter.SelectedIndex.ToString();
            DateTime beginDatum=dtpBeginDatum.Value,
                eindDatum=dtpEindDatum.Value;

            Event evenement = new Event(naam, beginDatum, eindDatum, plaats, adres);
        }

        private void cbEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string itemselected = Convert.ToString(cbEvents.SelectedItem);
            foreach (Event ev in admin.Events)
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
            tbPlaats.Text = evenement.Plaats;
            tbAdres.Text = evenement.Adres;
            // nu die cb updaten :|

            cbPlaats.SelectedValue = evenement.Plaats;
            foreach (Plaats p in evenement.Plaatsen)
            {
                cbPlaatsen.Items.Add(p.ToString());
            }

            
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
    }
}
