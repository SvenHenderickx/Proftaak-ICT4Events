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
        private Hoofdboeker hoofdboeker;

        public InschrijfForm()
        {
            InitializeComponent();
            administratie = new Administratie();
            geselecteerdePlaatsen = new List<Plaats>();
            VulComboBox();
        }

        // Event Handlers
        private void btnMaakBezoeker_Click(object sender, EventArgs e)
        {
            if(tbNaam.Text != "" && tbWachtwoord.Text != "")
            {
                hoofdboeker = new Hoofdboeker(tbNaam.Text, tbWachtwoord.Text, dtpGebDatum.Value, tbRekNr.Text);
                // hoofdboeker moet ook nog toegevoegd worden aan SME Event
                MessageBox.Show("Hoofdboeker Gemaakt");
                gbGegevens.Enabled = false;
                Reservering nieuweReservering = new Reservering(hoofdboeker, geselecteerdePlaatsen);
                // nieuwereservering moet nog toegevoegd worden aan alle reserveringen.
            }
            else
            {
                MessageBox.Show("Niet alle gegevens juist ingevuld");
            }
        }

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

        private void btnVolgende_Click(object sender, EventArgs e)
        {
            // checken of alle textboxen goed zijn aangemaakt, 
            // hieruit kan de hoofdboeker gemaakt worden, met bijbehorende reservering

            // als alles is ingevuld wordt de bezoeker ook daadwerkelijk aangemaakt
            // dit kan als de gebruiker van het programma op volgende klikt of dat
            // de gebruiker op huurmateriaal klikt.
            if (hoofdboeker != null)
            {
                if (chbMeerPersonen.Checked && cbMeerderePersonen.SelectedItem != null)
                {
                    InschrijfFormBezoeker inschrijfformBezoeker = new InschrijfFormBezoeker((int)cbMeerderePersonen.SelectedItem, hoofdboeker);
                    inschrijfformBezoeker.Show();
                }
            }
            else
            {
                MessageBox.Show("Maak eerst een hoofdboeker");
            }
        }

        private void btnMateriaalHuren_Click(object sender, EventArgs e)
        {
            if (hoofdboeker != null)
            {
                MateriaalVerhuurForm MVF = new MateriaalVerhuurForm(hoofdboeker);
                MVF.Show();
            }
            else
            {
                MessageBox.Show("Maak eerst een hoofdboeker");
            }
        }

        private void chbMeerPersonen_CheckedChanged(object sender, EventArgs e)
        {
            if (chbMeerPersonen.Checked)
            {
                cbMeerderePersonen.Enabled = true;
            }
            else
            {
                cbMeerderePersonen.Enabled = false;
                cbMeerderePersonen.Items.Clear();
            }
            Ververs();
        }

        // Methoden
        private void VulComboBox()
        {
            // nog kijken of een plaats al bezet is of niet.
            // alleen niet bezette plaatsen toevoegen!!!
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
