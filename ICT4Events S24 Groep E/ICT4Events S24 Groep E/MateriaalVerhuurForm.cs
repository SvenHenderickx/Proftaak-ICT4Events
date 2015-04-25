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
        //Fields
        private Administratie administratie;
        private Hoofdboeker hoofdboeker;
        private Bezoeker bezoeker;
        private List<string> bezoekerMateriaal;

        
        public MateriaalVerhuurForm(Bezoeker bezoeker)
        {
            InitializeComponent();
            administratie = new Administratie();
            VulCbCameras();
            this.bezoeker = bezoeker;
            lblBoekerBezoekerInfo.Text = bezoeker.ToString();
            bezoekerMateriaal = new List<String>();
            Ververs(); // Geef alvast alle items die een bezoeker gehuurd zou kunnen hebben.
        }
       
        public MateriaalVerhuurForm(Hoofdboeker hoofdboeker)
        {
            InitializeComponent();
            administratie = new Administratie();
            VulCbCameras();
            this.hoofdboeker = hoofdboeker;
            lblBoekerBezoekerInfo.Text = hoofdboeker.ToString();
            bezoekerMateriaal = new List<String>();
            bezoeker = (Bezoeker)hoofdboeker;
            Ververs();
        }

        //Event Handlers
        // deze is niet meer nodig want alles staat in één combobox
        private void btnFotoKies_Click(object sender, EventArgs e)
        {
            //ItemHuren(cbFotoCamera);
            Ververs();
        }

        // btnHuuritemkies
        private void btnVideoKies_Click(object sender, EventArgs e)
        {
            ItemHuren(cbHuurItems);
            Ververs();
        }

        private void btnVerwijder_Click(object sender, EventArgs e)
        {
            if (lbGekozenItems.SelectedItem != null)
            {
                Huuritem huuritem = administratie.HuidigEvent.GeefHuuritem(lbGekozenItems.SelectedItem.ToString());
                //bezoeker.HuurMateriaal.Remove(huuritem);
                bezoekerMateriaal.Remove(lbGekozenItems.SelectedItem.ToString());
                huuritem.IsGehuurd = false;
                administratie.DatabaseKoppeling.GeefHuuritemVrij(huuritem.Naam);
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
            
            // hier worden alle materialen die gehuurd worden toegewezen aan de
            // bezoeker in de database
            // wij wijzen hem niet toe aan een bezoeker maar aan een reservering. 
            // dus het huuritem is eigenlijk voor de hele groep..
            
            this.Dispose();
        }

        // Methods
        private void Ververs()
        {
            lbGekozenItems.Items.Clear();
            if (bezoeker.HuurMateriaal != null)
            {
                foreach (string s in bezoekerMateriaal)
                {
                    lbGekozenItems.Items.Add(s);
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
                    //bezoeker.HuurMateriaal.Add(huuritem);
                    // sla de naam van het materiaal op
                    bezoekerMateriaal.Add(huuritem.Naam);
                    huuritem.IsGehuurd = true;
                    administratie.DatabaseKoppeling.ReserveerHuuritem(huuritem.Naam);
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
            cbHuurItems.Items.Clear();
            bool cbVCam = false;

            foreach (Huuritem h in administratie.HuidigEvent.DatabaseKoppeling.HaalHuuritemsOp())
            {
                if (!h.IsGehuurd) // cycles verminderen als er een lange lijst is.
                {
                    cbHuurItems.Items.Add(h.Naam);
                    if (!cbVCam) //cycles verminderen als er een lange lijst is.
                    {
                        cbHuurItems.SelectedIndex = 0;
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
            foreach (string s in lbGekozenItems.Items)
            {

                if (lbGekozenItems.Items == null) break;
                // deze wordt niet meer gebruikt
                huuritem = administratie.HuidigEvent.GeefHuuritem(s.ToString());
                
                bezoekerMateriaal.Remove(s);
                // deze wordt niet meer gebruikt
                huuritem.IsGehuurd = false;
                administratie.DatabaseKoppeling.GeefHuuritemVrij(s);
            }
            Ververs();
            // this.Close();
        }
    }
}
