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
    public partial class MediaSharingForm : Form
    {
        Administratie administratie;

        public MediaSharingForm()
        {
            InitializeComponent();
            administratie = new Administratie();
            LaadAlleBerichten();
        }

        private void MediaSharingAfsluiten(object sender, FormClosedEventArgs e)
        {
            if (administratie.NuIngelogd is Bezoeker)
            {
                var loginForm = new LoginForm();
                loginForm.Show();
                this.Hide();
            }
            if (administratie.NuIngelogd is Beheerder)
            {
                var systeemKiezerForm = new SysteemKiezerForm();
                systeemKiezerForm.Show();
                this.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            administratie.HuidigEvent.Berichten.Add(new Bericht(tbPostTekstMediaSharingForm.Text, administratie.NuIngelogd));
            LaadAlleBerichten();
        }

        private void LaadAlleBerichten()
        {
            lbBerichtenTest.Items.Clear();
            foreach (Bericht b in administratie.HuidigEvent.Berichten)
            {
                lbBerichtenTest.Items.Add(b.Auteur.Gebruikersnaam + ": " + b.Tekst);
            }
        }
    }
}
