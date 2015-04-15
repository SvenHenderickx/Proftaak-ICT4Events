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

        public PostForm()
        {
            InitializeComponent();
            administratie = new Administratie();
            VerversBericht();
            LaadAlleReacties();
        }

        private void LaadAlleReacties()
        {
            lbReacties.Items.Clear();
            foreach (Reactie r in administratie.TempBericht.Reacties)
            {
                lbReacties.Items.Add(r.Plaatser + ": " + r.Inhoud);
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
    }
}
