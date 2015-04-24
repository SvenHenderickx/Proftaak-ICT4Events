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
    public partial class LoginForm : Form
    {
        //Field
        Administratie administratie;

        public LoginForm()
        {
            InitializeComponent();
            administratie = new Administratie();
            administratie.HaalAlleEventsOp();
            KrijgAlleEvents();
            cmbEventsLoginForm.SelectedIndex = 0;
        }

        //Event Handlers
        private void btnInlogLoginForm_Click(object sender, EventArgs e)
        {
            Persoon tempPersoon = null;
            if (cmbEventsLoginForm.Text.Length > 0)
            {
                string test = cmbEventsLoginForm.Text;
                administratie.VoegAlleGebruikersToeAanEvent(cmbEventsLoginForm.Text);
                Event evenement = administratie.GeefEvent(cmbEventsLoginForm.Text);
                tempPersoon = evenement.CheckGebruikersNaamRfid(tbGebRfidLoginForm.Text);
                if (tempPersoon != null)
                {
                    if (tempPersoon.CheckWachtwoord(tbWachtwoordLoginForm.Text))
                    {
                        administratie.HuidigEvent = evenement;
                        administratie.NuIngelogd = tempPersoon;
                        AutomatischeDoorverbinding();
                    }
                    else
                    {
                        MessageBox.Show("Fout wachtwoord ingevoerd.");
                    }
                }
                else
                {
                    MessageBox.Show("Kan gebruiker niet vinden.");
                }
            }
            
        }

        private void KrijgAlleEvents()
        {
            foreach (Event e in administratie.Events)
            {
                cmbEventsLoginForm.Items.Add(e.Naam);
            }
        }

        private void SluitHeleApplicatie(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void AutomatischeDoorverbinding()
        {
            if (administratie.NuIngelogd is Controleur)
            {
                var toegangsControleForm = new Toegangscontroleform();
                toegangsControleForm.Show();
                this.Hide();
            }
            else if (administratie.NuIngelogd is Bezoeker)
            {
                var mediaSharingForm = new MediaSharingForm();
                mediaSharingForm.Show();
                this.Hide();
            }
            else
            {
                var systeemKiezerForm = new SysteemKiezerForm();
                systeemKiezerForm.Show();
                this.Hide();
            }
        }

        private void btnInschrijvenInloggenForm_Click(object sender, EventArgs e)
        {
            // Frank: bij het inschrijven moet ik ook personen aan een bepaald evenement toevoegen dus 
            // dit stuk code hieronder moet ik ook gebruiken.
            Event evenement = administratie.GeefEvent(cmbEventsLoginForm.Text);
            administratie.HuidigEvent = evenement;
            var inschrijfForm = new InschrijfForm();
            inschrijfForm.Show();
        }

        private void tbWachtwoordLoginForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && tbGebRfidLoginForm.Text != "" && tbWachtwoordLoginForm.Text != "")
            {
                Persoon tempPersoon = null;
            if (cmbEventsLoginForm.Text.Length > 0)
            {
                Event evenement = administratie.GeefEvent(cmbEventsLoginForm.Text);
                tempPersoon = evenement.CheckGebruikersNaamRfid(tbGebRfidLoginForm.Text);
                if (tempPersoon != null)
                {
                    if (tempPersoon.CheckWachtwoord(tbWachtwoordLoginForm.Text))
                    {
                        administratie.HuidigEvent = evenement;
                        administratie.NuIngelogd = tempPersoon;
                        AutomatischeDoorverbinding();
                    }
                    else
                    {
                        MessageBox.Show("Fout wachtwoord ingevoerd.");
                    }
                }
                else
                {
                    MessageBox.Show("Kan gebruiker niet vinden.");
                }
            }
            }
        }

        
    }
}
