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
    public partial class PostForm : Form
    {
        Administratie administratie;
        bool rapportages;

        public PostForm()
        {
            InitializeComponent();
            administratie = new Administratie();
            VerversBericht();
            LaadAlleReacties();
            CheckBeheerder();
            rapportages = false;
        }

        private void LaadAlleReacties()
        {
            lbReacties.Items.Clear();
            foreach (Reactie r in administratie.TempBericht.Reacties)
            {
                lbReacties.Items.Add(r.ToString());
            }
        }

        private void LaadAlleRapportages(List<Rapportage> rapportages)
        {
            lbReacties.Items.Clear();
            foreach (Rapportage r in rapportages)
            {
                lbReacties.Items.Add(r.ToString());
            }
        }

        private void VerversBericht()
        {
            lblBerichtTekst.Text = administratie.TempBericht.Tekst;
            gbGebnaam.Text = administratie.TempBericht.Auteur.Gebruikersnaam;
            lbDatum.Text = administratie.TempBericht.DatumGepost.ToString();
            lbLikes.Text = administratie.TempBericht.Likes.Count.ToString() + " Like(s)";
        }

        private void btnLike_Click(object sender, EventArgs e)
        {
            if (administratie.TempBericht.BerichtLiken(administratie.NuIngelogd))
            {
                VerversBericht();
            }
        }

        private void btnPlaatsReactie_Click(object sender, EventArgs e)
        {
            if (tbReactieTekst.Text.Length > 0)
            {
                administratie.TempBericht.ReactieToevoegen(tbReactieTekst.Text, administratie.NuIngelogd);
                tbReactieTekst.Text = "";
            }
            LaadAlleReacties();
        }

        private void btnRapporteer_Click(object sender, EventArgs e)
        {
            if (tbReactieTekst.Text.Length > 0 && CheckBeheerder() == false)
            {
                if (administratie.TempBericht.Rapporteren(tbReactieTekst.Text, administratie.NuIngelogd))
                {
                    MessageBox.Show("Succesvol Gerapporteerd, bedankt.");
                }
                else
                {
                    MessageBox.Show("U heeft deze post waarschijnlijk al eens gerapporteerd.");
                }
                tbReactieTekst.Text = "";
            }
            else if (CheckBeheerder() == true)
            {
                if (rapportages == false)
                {
                    rapportages = true;
                    LaadAlleRapportages(administratie.TempBericht.Rapportages);
                }
                else
                {
                    rapportages = false;
                    LaadAlleReacties();
                }
                
            }
            else
            {
                MessageBox.Show("Vul reden voor rapportage in in reactie tekstbox.");
            }
        }

        public bool CheckBeheerder()
        {
            if (administratie.NuIngelogd is Beheerder || administratie.TempBericht.Auteur == administratie.NuIngelogd)
            {
                if (administratie.NuIngelogd is Beheerder)
                {
                    if (rapportages == false)
                    {
                        btnRapporteer.Text = "Reacties";
                    }
                    else
                    {
                        btnRapporteer.Text = "Rapportages";
                    }
                }
                
                btnBerichtVerwijderen.Visible = true;
                btnReactieVerwijderen.Visible = true;
                return true;
            }
            else
            {
                btnBerichtVerwijderen.Visible = false;
                btnReactieVerwijderen.Visible = false;
            }
            return false;
        }

        private void btnReactieVerwijderen_Click(object sender, EventArgs e)
        {
            if (lbReacties.SelectedIndex >= 0)
            {
                administratie.TempBericht.ReactieVerwijder(administratie.TempBericht.ReactieZoekenMetToString(lbReacties.SelectedItem.ToString()));
                LaadAlleReacties();
            }
        }

        private void btnBerichtVerwijderen_Click(object sender, EventArgs e)
        {
            administratie.HuidigEvent.VerwijderBericht(administratie.TempBericht);
            this.Close();
        }

        private void PostForm_Load(object sender, EventArgs e)
        {

        }
    }
}
