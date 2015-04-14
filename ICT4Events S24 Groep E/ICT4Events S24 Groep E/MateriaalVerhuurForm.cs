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
                Huuritem huuritem = administratie.GeefEvent("SME Event").GeefHuuritem(lbGekozenItems.SelectedItem.ToString());
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
                Huuritem huuritem = administratie.GeefEvent("SME Event").GeefHuuritem(cb.SelectedItem.ToString());
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
            foreach (Huuritem h in administratie.GeefEvent("SME Event").HuurMateriaal)
            {
                if (h.Type == "Fotocamera" && !h.IsGehuurd)
                {
                    cbFotoCamera.Items.Add(h.Naam);
                }
                else if (h.Type == "Videocamera" && !h.IsGehuurd)
                {
                    cbVideoCamera.Items.Add(h.Naam);
                }
            }
        }
    }
}
