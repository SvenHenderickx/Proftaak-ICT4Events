using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceProcess;

namespace ICT4Events_S24_Groep_E
{
    public partial class EventBeheerForm : Form
    {
        System.Windows.Forms.Timer timer;
        int interval = 3000;


        public EventBeheerForm()
        {
            InitializeComponent();
            timer = new System.Windows.Forms.Timer();
            
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
    }
}
