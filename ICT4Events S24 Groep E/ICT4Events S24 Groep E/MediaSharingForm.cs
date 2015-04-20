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
        //Field
        Administratie administratie;
        OpenFileDialog opd;
        string bestandPad;

        public MediaSharingForm()
        {
            InitializeComponent();
            administratie = new Administratie();
            opd = new OpenFileDialog();
            bestandPad = "";
            CheckFilter();
            CheckGebruiker();
        }

        //Event Handlers
        private void MediaSharingAfsluiten(object sender, FormClosedEventArgs e)
        {
            if (administratie.NuIngelogd is Bezoeker)
            {
                administratie.NuIngelogd = null;
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
            if (tbPostTekstMediaSharingForm.Text.Length > 0 && bestandPad.Length == 0)
            {
                administratie.HuidigEvent.Berichten.Add(new Bericht(tbPostTekstMediaSharingForm.Text, administratie.NuIngelogd));
                tbPostTekstMediaSharingForm.Text = "";
                CheckFilter();
            }
            else if (tbPostTekstMediaSharingForm.Text.Length > 0 && bestandPad.Length > 0)
            {
                administratie.HuidigEvent.Berichten.Add(new Bericht(tbPostTekstMediaSharingForm.Text, administratie.NuIngelogd, new Bestand(bestandPad), 1));
                tbPostTekstMediaSharingForm.Text = "";
                CheckFilter();
                bestandPad = "";
            }
            
        }

        public void CheckFilter()
        {
            if (rbAlles.Checked == true)
            {
                LaadAlleBerichten(administratie.HuidigEvent.GeefBerichtenVanSoort(0));
            }
            else if (rbBerichten.Checked == true)
            {
                LaadAlleBerichten(administratie.HuidigEvent.GeefBerichtenVanSoort(1));
            }
            else if (rbFotos.Checked == true)
            {
                LaadAlleBerichten(administratie.HuidigEvent.GeefBerichtenVanSoort(2));
            }
        }

        private void LaadAlleBerichten(List<Bericht> berichten)
        {
            lbBerichtenMediaSharingForm.Items.Clear();
            berichten.Sort();
            foreach (Bericht b in berichten)
            {
                lbBerichtenMediaSharingForm.Items.Add(b.ToString());
            }
        }

        private void btnLikeMediaSharing_Click(object sender, EventArgs e)
        {
            if (lbBerichtenMediaSharingForm.SelectedIndex >= 0)
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
            if (lbBerichtenMediaSharingForm.SelectedIndex >= 0)
            {
                administratie.TempBericht = BerichtOpIndex();
                var postForm = new PostForm();
                postForm.Show();
            }
        }

        private Bericht BerichtOpIndex()
        {
            if(lbBerichtenMediaSharingForm.SelectedItem!= null)
            {
                string test = lbBerichtenMediaSharingForm.SelectedItem.ToString();
                return administratie.HuidigEvent.GeefBerichtDoorToString(lbBerichtenMediaSharingForm.SelectedItem.ToString());
            }
            MessageBox.Show("Selecteer eerst een bericht", "Geen bericht geselecteerd");
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

        public void CheckGebruiker()
        {
            if (administratie.NuIngelogd is Beheerder)
            {
                btnVerwijderBericht.Visible = true;
                btnGerapporteerdeBerichten.Visible = true;
                
            }
            else
            {
                btnVerwijderBericht.Visible = false;
                btnGerapporteerdeBerichten.Visible = false;
            }
        }

        private void btnVerwijderBericht_Click(object sender, EventArgs e)
        {
            if (lbBerichtenMediaSharingForm.SelectedIndex >= 0)
            {
                administratie.HuidigEvent.VerwijderBericht(BerichtOpIndex());
                LaadAlleBerichten(administratie.HuidigEvent.Berichten);
            }
            
        }

        private void btnGerapporteerdeBerichten_Click(object sender, EventArgs e)
        {
            LaadAlleBerichten(administratie.HuidigEvent.AlleGerapporteerdeBerichten());
        }

        private void btnBeheren_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            opd.Filter = "Photo files (*.jpg)|*.jpg";
            
            if (opd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                bestandPad = opd.FileName;
            }
        }

        private void rbAlles_CheckedChanged(object sender, EventArgs e)
        {
            CheckFilter();
        }

        private void rbBerichten_CheckedChanged(object sender, EventArgs e)
        {
            CheckFilter();
        }

        private void rbFotos_CheckedChanged(object sender, EventArgs e)
        {
            CheckFilter();
        }
    }
}
