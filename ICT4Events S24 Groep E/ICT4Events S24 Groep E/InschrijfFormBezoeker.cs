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
        //Fields
        private int resterendeBezoekers;
        private Hoofdboeker hoofdBoeker; // de hoofdboeker van de bezoeker nodig voor constructor nieuwe bezoeker.
        private Bezoeker bezoeker;
        private Administratie administratie;
        private int reserveringID;
        private DatabaseKoppeling dbKoppeling;

        public InschrijfFormBezoeker(int resterendeBezoekers, Hoofdboeker hoofdboeker, int reserveringID)
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
            this.reserveringID = reserveringID;
            dbKoppeling = new DatabaseKoppeling();
        }

        //Event Handlers
        private void btnMateriaalHuren_Click(object sender, EventArgs e)
        {
            if (bezoeker != null)
            {
                MateriaalVerhuurForm MVF = new MateriaalVerhuurForm(bezoeker, reserveringID);
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
                    if(dbKoppeling.MaakPersoon(bezoeker, administratie.HuidigEvent.Naam) && dbKoppeling.MaakBezoeker(bezoeker, reserveringID))
                    {
                        MessageBox.Show("Bezoeker is aangemaakt.");
                    }
                    
                    InschrijfFormBezoeker ISFB1 = new InschrijfFormBezoeker(resterendeBezoekers - 1, hoofdBoeker, reserveringID);
                    ISFB1.Show();
                }
                else
                {
                    // hier wordt de gebruiker definitief gemaakt.
                    if (dbKoppeling.MaakPersoon(bezoeker, administratie.HuidigEvent.Naam) && dbKoppeling.MaakBezoeker(bezoeker, reserveringID))
                    {
                        MessageBox.Show("Alle Bezoekers Toegevoegd");
                    }
                    // hierna automatisch door naar het inlogform als er
                    if (administratie.NuIngelogd is Beheerder)
                    {
                        var systeemKiesForm = new SysteemKiezerForm();
                        systeemKiesForm.Show();
                    }                    
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
                if (tbWachtwoord.Text != tbWachtwoordConfirm.Text)
                {
                    MessageBox.Show("Wachtwoorden komen niet overeen. \n Controleer uw wachtwoord nogmaals.");
                }
                else
                {
                    bezoeker = new Bezoeker(tbGebruikersNaam.Text, tbWachtwoord.Text, dtpGebDatum.Value, hoofdBoeker, tbNaam.Text, tbAchternaam.Text, dbKoppeling.GeefVolgendeRFID() , false);
                    if (administratie.HuidigEvent.CheckPersoon(bezoeker))
                    {
                        gbGegevens.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Gebruikersnaam bestaat al");
                    }
                }
            }
            else
            {
                MessageBox.Show("Niet alle gegevens goed ingevoerd");
            }
        }

        private void btnAnnuleren_Click(object sender, EventArgs e)
        {
            if(bezoeker != null)
            {
                bezoeker.LeegMateriaal(bezoeker);
                bezoeker = null;
            }
            gbGegevens.Enabled = true;
        }

        private void InschrijfFormBezoeker_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (administratie.NuIngelogd is Beheerder)
            {
                var SysteemKiezer = new SysteemKiezerForm();
                SysteemKiezer.Show();
            }
        }
    }
}
