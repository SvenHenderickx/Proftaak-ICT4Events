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

        Administratie administartie;

        public LoginForm()
        {
            InitializeComponent();
            administartie = new Administratie();
            KrijgAlleEvents();
            cmbEventsLoginForm.SelectedIndex = 0;
        }

        private void btnInlogLoginForm_Click(object sender, EventArgs e)
        {
            Persoon tempPersoon = null;
            if (cmbEventsLoginForm.Text.Length > 0)
            {
                Event evenement = administartie.GeefEvent(cmbEventsLoginForm.Text);
                tempPersoon = evenement.CheckGebruikersNaamRfid(tbGebRfidLoginForm.Text);
                if (tempPersoon != null)
                {
                    if (tempPersoon.CheckWachtwoord(tbWachtwoordLoginForm.Text))
                    {
                        tempPersoon = administartie.NuIngelogd;
                        evenement = administartie.HuidigEvent;
                        var systeemKiezerForm = new SysteemKiezerForm();
                        systeemKiezerForm.Show();
                        this.Hide();
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
            foreach (Event e in administartie.Events)
            {
                cmbEventsLoginForm.Items.Add(e.Naam);
            }
        }

        private void SluitHeleApplicatie(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
