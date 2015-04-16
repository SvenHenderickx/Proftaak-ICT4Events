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
            LaadAlleBerichten(administratie.HuidigEvent.Berichten);
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
            if (tbPostTekstMediaSharingForm.Text.Length > 0)
            {
                administratie.HuidigEvent.Berichten.Add(new Bericht(tbPostTekstMediaSharingForm.Text, administratie.NuIngelogd));
                tbPostTekstMediaSharingForm.Text = "";
                LaadAlleBerichten(administratie.HuidigEvent.Berichten);
            }
            
        }

        private void LaadAlleBerichten(List<Bericht> berichten)
        {
            lbBerichtenMediaSharingForm.Items.Clear();
            foreach (Bericht b in berichten)
            {
                lbBerichtenMediaSharingForm.Items.Add(b.Auteur.Gebruikersnaam + " " + b.ToString());
            }
        }

        private void btnLikeMediaSharing_Click(object sender, EventArgs e)
        {
            if (BerichtOpIndex() != null)
            {
                if (BerichtOpIndex().BerichtLiken(administratie.NuIngelogd))
                {
                    //
                }
                else
                {
                    MessageBox.Show("Al geliked");
                }
            }
            LaadAlleBerichten(administratie.HuidigEvent.Berichten);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (BerichtOpIndex() != null)
            {
                administratie.TempBericht = BerichtOpIndex();
                var postForm = new PostForm();
                postForm.Show();
            }
        }

        private Bericht BerichtOpIndex()
        {
            for (int i = 0; i < administratie.HuidigEvent.Berichten.Count; i++)
            {
                if (lbBerichtenMediaSharingForm.SelectedIndex == i)
                {
                    return administratie.HuidigEvent.Berichten[i];
                }
            }
            return null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (administratie.HuidigEvent.BerichtenZoeken(tbZoeken.Text) != null && administratie.HuidigEvent.BerichtenZoeken(tbZoeken.Text).Count > 0)
            {
                LaadAlleBerichten(administratie.HuidigEvent.BerichtenZoeken(tbZoeken.Text));
            }
            else if(administratie.HuidigEvent.BerichtenZoeken(tbZoeken.Text).Count == 0)
            {
                MessageBox.Show("Geen Resultaten gevonden.");
                LaadAlleBerichten(administratie.HuidigEvent.Berichten);
            }
        }

        private void LiveUpdate(object sender, EventArgs e)
        {
            if (tbZoeken.Text.Length == 0)
            {
                LaadAlleBerichten(administratie.HuidigEvent.Berichten);
                gbZoeken.ForeColor = Color.Black;
            }
            else if (administratie.HuidigEvent.BerichtenZoeken(tbZoeken.Text) != null && administratie.HuidigEvent.BerichtenZoeken(tbZoeken.Text).Count > 0)
            {
                LaadAlleBerichten(administratie.HuidigEvent.BerichtenZoeken(tbZoeken.Text));
                gbZoeken.ForeColor = Color.Black;
            }
            else
            {
                gbZoeken.ForeColor = Color.Red;
            }
        }
    }
}
