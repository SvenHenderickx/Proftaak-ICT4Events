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
    public partial class InschrijfForm : Form
    {
        // Fields
        private Administratie administratie;
        private List<Plaats> geselecteerdePlaatsen;

        public InschrijfForm()
        {
            InitializeComponent();
            administratie = new Administratie();
            geselecteerdePlaatsen = new List<Plaats>();
            VulComboBox();
        }

        // Event Handlers
        private void btnVoegPlaatsToe_Click(object sender, EventArgs e)
        {
            if (cbPlaats.SelectedItem != null)
            {
                string plaats = cbPlaats.SelectedItem.ToString();
                Plaats gekozenPlaats = administratie.GeefEvent("SME Event").GeefPlaats(plaats.Substring(10, 4));
                if (!gekozenPlaats.Bezet)
                {
                    gekozenPlaats.Bezet = true;
                    geselecteerdePlaatsen.Add(gekozenPlaats);
                }
                else
                {
                    MessageBox.Show("Plaats is al gekozen");
                }
            }
            Ververs();
        }

        private void btnVerwijderPlaats_Click(object sender, EventArgs e)
        {
            if (lbPlaatsen.SelectedItem != null)
            {
                string plaats = lbPlaatsen.SelectedItem.ToString();
                Plaats gekozenPlaats = administratie.GeefEvent("SME Event").GeefPlaats(plaats.Substring(10, 4));
                geselecteerdePlaatsen.Remove(gekozenPlaats);
                gekozenPlaats.Bezet = false;
            }
            Ververs();
        }

        // Methoden
        private void VulComboBox()
        {
            foreach (Plaats p in administratie.GeefEvent("SME Event").Plaatsen)
            {
                cbPlaats.Items.Add(p.ToString());
            }
        }

        private void Ververs()
        {
            // De geselecteerde plaatsen komen in de listbox als ze verwijderd zijn gaan ze er weer uit.
            lbPlaatsen.Items.Clear();
            foreach (Plaats p in geselecteerdePlaatsen)
            {
                lbPlaatsen.Items.Add(p.ToString());
            }

            // cbMeerderePersonen wordt gevuld
            cbMeerderePersonen.Items.Clear();
            int personen = 1;
            foreach (Plaats p in geselecteerdePlaatsen)
            {
                personen += p.AantalPersonen;
            }
            for (int i = 1; i < personen; i++)
            {
                cbMeerderePersonen.Items.Add(i);
            }
        }



    }
}
