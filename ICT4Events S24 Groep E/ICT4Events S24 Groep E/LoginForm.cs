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
        }

        private void btnInlogLoginForm_Click(object sender, EventArgs e)
        {
            Persoon tempPersoon = null;
            tempPersoon = administartie.CheckGebruikersInEvent(tbGebRfidLoginForm.ToString());
            if (tempPersoon != null)
            {
                if (tempPersoon.CheckWachtwoord(tbWachtwoordLoginForm.ToString()))
                {
                    MessageBox.Show("Geslaagd");
                }
            }
        }
    }
}
