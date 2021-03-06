﻿using System;
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
        //Fields
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

        //Event Handlers
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
            //lblBerichtTekst.Text = administratie.TempBericht.Tekst;
            LaatTekstZien();
            gbGebnaam.Text = administratie.TempBericht.Auteur.Gebruikersnaam;
            lbDatum.Text = administratie.TempBericht.DatumGepost.ToString();
            lbLikes.Text = administratie.TempBericht.Likes.Count.ToString() + " Like(s)";
            if (administratie.TempBericht.HeeftEenBestand() && administratie.TempBericht.BerichtSoort == 1)
            {
                Image image = Image.FromFile(administratie.TempBericht.GeefBestandPad());
                pbFoto.Image = image;
                pbFoto.SizeMode = PictureBoxSizeMode.Zoom;
                this.Width = 660;
            }
            else
            {
                this.Width = 328;
            }

            if (administratie.TempBericht.CheckBerichtGeliked(administratie.NuIngelogd))
            {
                btnLike.Text = "Unlike";
            }
            else
            {
                btnLike.Text = "Like";
            }
        }

        public void LaatTekstZien()
        {
            if (administratie.TempBericht.Tekst.Length > 30)
            {
                string temp = administratie.TempBericht.Tekst;
                for (int i = 30; i < temp.Length; i = i + 30)
                {
                    temp = temp.Substring(0, i) + "\n" + temp.Substring(i, temp.Length - i);
                }
                //string temp = administratie.TempBericht.Tekst;
                //temp = temp.Substring(0, 30) + "\n" + temp.Substring(30, temp.Length - 30);
                //if (administratie.TempBericht.Tekst.Length > 60)
                //{
                //    temp = temp.Substring(0, 60) + "\n" + temp.Substring(30, temp.Length - 60);
                //}
                lblBerichtTekst.Text = temp;
            }
            else
            {
                lblBerichtTekst.Text = administratie.TempBericht.Tekst;
            }
        }


        private void btnLike_Click(object sender, EventArgs e)
        {
            if (administratie.TempBericht.BerichtLiken(administratie.NuIngelogd))
            {
                VerversBericht();
            }
            else
            {
                administratie.TempBericht.BerichtUnliken(administratie.NuIngelogd);
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

        private void pbFoto_Click(object sender, EventArgs e)
        {
            var postFormImage = new PostFormImage();
            postFormImage.Show();
        }
    }
}
