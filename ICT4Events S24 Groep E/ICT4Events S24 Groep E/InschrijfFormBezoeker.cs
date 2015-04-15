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
    public partial class InschrijfFormBezoeker : Form
    {
        private int resterendeBezoekers;
        private Hoofdboeker hoofdBoeker; // de hoofdboeker van de bezoeker nodig voor constructor nieuwe bezoeker.
        private Bezoeker bezoeker;
        private Administratie administratie;

        public InschrijfFormBezoeker(int resterendeBezoekers, Hoofdboeker hoofdboeker)
        {
            InitializeComponent();
            this.resterendeBezoekers = resterendeBezoekers;
            this.hoofdBoeker = hoofdboeker;
            lblResterendeBezoekers.Text = resterendeBezoekers.ToString();
            lblHoofdboekerInfo.Text = hoofdboeker.ToString();
            administratie = new Administratie();
            if (resterendeBezoekers == 1)
            {
                btnVolgende.Text = "Bevestig Inschrijving";
            }
        }

        private void btnMateriaalHuren_Click(object sender, EventArgs e)
        {
            if (bezoeker != null)
            {
                MateriaalVerhuurForm MVF = new MateriaalVerhuurForm(bezoeker);
                MVF.Show();
            }
            else
            {
                MessageBox.Show("Maak eerst een bezoeker aan");
            }
        }

        private void btnVolgende_Click(object sender, EventArgs e)
        {
            if (bezoeker != null)
            {
                if (resterendeBezoekers >= 2)
                {
                    administratie.HuidigEvent.VoegPersoonToe(bezoeker);
                    InschrijfFormBezoeker ISFB1 = new InschrijfFormBezoeker(resterendeBezoekers - 1, hoofdBoeker);
                    ISFB1.Show();
                }
                else
                {
                    // hier wordt de gebruiker definitief gemaakt.
                    administratie.HuidigEvent.VoegPersoonToe(bezoeker);
                    MessageBox.Show("Alle Bezoekers Toegevoegd");
                    // hierna automatisch door naar het inlogform
                }
                this.Dispose(); // Verwijderen van het form zodat er weer een nieuwe kan komen
            }
            else
            {
                MessageBox.Show("Maak eerst een bezoeker aan");
            }
        }

        private void btnMaakBezoeker_Click(object sender, EventArgs e)
        {
            if (tbGebruikersNaam.Text != "" && tbWachtwoord.Text != "" && tbNaam.Text != "" && tbAchternaam.Text != "")
            {
                bezoeker = new Bezoeker(tbGebruikersNaam.Text, tbWachtwoord.Text, dtpGebDatum.Value, hoofdBoeker, tbNaam.Text, tbAchternaam.Text);
                if(administratie.HuidigEvent.CheckPersoon(bezoeker))
                {
                    gbGegevens.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Gebruikersnaam bestaat al");
                }
            }
            else
            {
                MessageBox.Show("Niet alle gegevens goed ingevoerd");
            }
        }

        private void btnAnnuleren_Click(object sender, EventArgs e)
        {
            bezoeker = null;
            gbGegevens.Enabled = true;
        }
    }
}
