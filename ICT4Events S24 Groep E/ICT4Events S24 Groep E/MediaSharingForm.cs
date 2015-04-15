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
    public partial class MediaSharingForm : Form
    {
        Administratie administratie;

        public MediaSharingForm()
        {
            InitializeComponent();
            administratie = new Administratie();
        }

        private void MediaSharingAfsluiten(object sender, FormClosedEventArgs e)
        {
            if (administratie.NuIngelogd is Bezoeker)
            {
                var loginForm = new LoginForm();
                loginForm.Show();
                this.Hide();
            }
            if (administratie.NuIngelogd is Beheerder)
            {
                var systeemKiezerForm = new SysteemKiezerForm();
                systeemKiezerForm.Show();
                this.Hide();
            }
        }
    }
}
