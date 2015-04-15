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
            if (tbPostTekstMediaSharingForm.Text.Length > 0)
            {
                administratie.HuidigEvent.Berichten.Add(new Bericht(tbPostTekstMediaSharingForm.Text, administratie.NuIngelogd));
                tbPostTekstMediaSharingForm.Text = "";
                LaadAlleBerichten();
            }
            
        }

        private void LaadAlleBerichten()
        {
            lbBerichtenMediaSharingForm.Items.Clear();
            foreach (Bericht b in administratie.HuidigEvent.Berichten)
            {
                lbBerichtenMediaSharingForm.Items.Add(b.Auteur.Gebruikersnaam + " " + b.ToString());
            }
        }

        private void btnLikeMediaSharing_Click(object sender, EventArgs e)
        {
            if (BerichtOpIndex() != null)
            {
                BerichtOpIndex().Likes++;
            }
            LaadAlleBerichten();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (BerichtOpIndex() != null)
            {
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
    }
}
