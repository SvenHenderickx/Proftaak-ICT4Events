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
    public partial class MateriaalVerhuurForm : Form
    {
        private Administratie administratie;
        private Hoofdboeker hoofdboeker;
        private Bezoeker bezoeker;

        public MateriaalVerhuurForm(Bezoeker bezoeker)
        {
            InitializeComponent();
            administratie = new Administratie();
            VulCbCameras();
            this.bezoeker = bezoeker;
            lblBoekerBezoekerInfo.Text = bezoeker.ToString();
            Ververs(); // Geef alvast alle items die een bezoeker gehuurd zou kunnen hebben.
        }

        public MateriaalVerhuurForm(Hoofdboeker hoofdboeker)
        {
            InitializeComponent();
            administratie = new Administratie();
            VulCbCameras();
            this.hoofdboeker = hoofdboeker;
            lblBoekerBezoekerInfo.Text = hoofdboeker.ToString();
            bezoeker = (Bezoeker)hoofdboeker;
            Ververs();
        }

        private void btnFotoKies_Click(object sender, EventArgs e)
        {
            ItemHuren(cbFotoCamera);
            Ververs();
        }

        private void btnVideoKies_Click(object sender, EventArgs e)
        {
            ItemHuren(cbVideoCamera);
            Ververs();
        }

        private void btnVerwijder_Click(object sender, EventArgs e)
        {
            if (lbGekozenItems.SelectedItem != null)
            {
                Huuritem huuritem = administratie.HuidigEvent.GeefHuuritem(lbGekozenItems.SelectedItem.ToString());
                bezoeker.HuurMateriaal.Remove(huuritem);
                huuritem.IsGehuurd = false;
            }
            else
            {
                MessageBox.Show("Selecteer een item om te verwijderen");
            }
            Ververs();
        }

        private void btnBevestig_Click(object sender, EventArgs e)
        {
            // button wordt nog niet gebruikt
            // kan gebruikt worden als het moet maar vereist aanpassingen.
            this.Dispose();
        }

        // Methods
        private void Ververs()
        {
            lbGekozenItems.Items.Clear();
            if (bezoeker.HuurMateriaal != null)
            {
                foreach (Huuritem h in bezoeker.HuurMateriaal)
                {
                    lbGekozenItems.Items.Add(h.Naam);
                }
            }
            VulCbCameras();
        }

        private void ItemHuren(ComboBox cb)
        {
            if (cb.SelectedItem != null)
            {
                Huuritem huuritem = administratie.HuidigEvent.GeefHuuritem(cb.SelectedItem.ToString());
                if (!huuritem.IsGehuurd)
                {
                    bezoeker.HuurMateriaal.Add(huuritem);
                    huuritem.IsGehuurd = true;
                }
                else
                {
                    MessageBox.Show("Huuritem is al gehuurd");
                }
            }
        }

        private void VulCbCameras()
        {
            // Alle FotoCamera's toevoegen die nog niet zijn uitgeleend
            
            
            cbFotoCamera.Items.Clear();
            cbVideoCamera.Items.Clear();
            bool cbFCam = false, cbVCam = false;

            foreach (Huuritem h in administratie.HuidigEvent.HuurMateriaal)
            {
                if (h.Type == "Fotocamera" && !h.IsGehuurd) // cycles verminderen als er een lange lijst is.
                {
                    cbFotoCamera.Items.Add(h.Naam);
                    if (!cbFCam)
                    {
                        cbFotoCamera.SelectedIndex = 0;
                        cbFCam = true;
                    }
                }
                else if (h.Type == "Videocamera" && !h.IsGehuurd)
                {
                    cbVideoCamera.Items.Add(h.Naam);
                    if (!cbVCam) //cycles verminderen als er een lange lijst is.
                    {
                        cbVideoCamera.SelectedIndex = 0;
                        cbVCam = true;
                    }
                }
            }
        }

        private void MateriaalVerhuurForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if bevestigd niet is aangeklikt dan alle huuritems terug plaatsen!!

            // hoe dit zal gaan in inschrijfform als die niet bevestigd moet ook nog worden gefixt.
        }

        private void btnAnnuleren_Click(object sender, EventArgs e)
        {
            Huuritem huuritem;
            foreach (object ob in lbGekozenItems.Items)
            {

                if (lbGekozenItems.Items == null) break;
                huuritem = administratie.HuidigEvent.GeefHuuritem(ob.ToString());
                bezoeker.HuurMateriaal.Remove(huuritem);
                huuritem.IsGehuurd = false;
            }
            Ververs();
            // this.Close();
        }
    }
}
