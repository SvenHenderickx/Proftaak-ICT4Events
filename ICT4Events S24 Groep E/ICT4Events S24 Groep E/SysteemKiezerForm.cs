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
    public partial class SysteemKiezerForm : Form
    {
        Administratie administratie;
        public SysteemKiezerForm()
        {
            InitializeComponent();
            administratie = new Administratie();
            lblEventSysteemKiezerForm.Text = administratie.NuIngelogd.Gebruikersnaam + ": " + administratie.HuidigEvent.Naam;
            AutomatischeDoorverbinding();
        }

        private void SysteemKiezerForm_Load(object sender, EventArgs e)
        {

        }

        private void TerugNaarLogin(object sender, FormClosedEventArgs e)
        {
            administratie.NuIngelogd = null;
            var logInForm = new LoginForm();
            logInForm.Show();
        }

        private void AutomatischeDoorverbinding()
        {
            if (administratie.NuIngelogd is Controleur)
            {
                var toegangsControleForm = new Toegangscontroleform();
                toegangsControleForm.Show();
                this.Hide();
            }
            else if (administratie.NuIngelogd is Bezoeker)
            {
                var mediaSharingForm = new MediaSharingForm();
                mediaSharingForm.Show();
                this.Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var mediaSharingForm = new MediaSharingForm();
            mediaSharingForm.Show();
            this.Hide();
        }

        private void btnEventBeheerSysteemKiezerForm_Click(object sender, EventArgs e)
        {
            var eventBeheerForm = new EventBeheerForm();
            eventBeheerForm.Show();
            this.Hide();
        }

        private void btnToegangsControleSysteemKiezerForm_Click(object sender, EventArgs e)
        {
            var toegangsControleForm = new Toegangscontroleform();
            toegangsControleForm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var inschrijfForm = new InschrijfForm();
            inschrijfForm.Show();
            this.Hide();
        }
    }
}
