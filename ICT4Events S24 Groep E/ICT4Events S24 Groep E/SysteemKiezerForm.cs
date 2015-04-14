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
    public partial class SysteemKiezerForm : Form
    {
        Administratie administratie;
        public SysteemKiezerForm()
        {
            InitializeComponent();
            administratie = new Administratie();
            lblEventSysteemKiezerForm.Text = administratie.HuidigEvent.Naam;
        }

        private void SysteemKiezerForm_Load(object sender, EventArgs e)
        {

        }

        private void TerugNaarLogin(object sender, FormClosedEventArgs e)
        {
            var logInForm = new LoginForm();
            logInForm.Show();
        }
    }
}
