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
        List<Event> events;
        List<Bezoeker> bezoekers;


        public EventBeheerForm()
        {
            InitializeComponent();
            timer = new System.Windows.Forms.Timer();
            events = new List<Event>();
            bezoekers = new List<Bezoeker>();
        }

        private void getAlleEvents()
        {
            events.Clear();
            // database connectie
            

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

        }

        private void btnVerwijderEvent_Click(object sender, EventArgs e)
        {

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
            updateEventTab();
        }
        private void updateEventTab()
        {
            // alle events specs invullen.... moet uit de database
            
        }
    }
}
