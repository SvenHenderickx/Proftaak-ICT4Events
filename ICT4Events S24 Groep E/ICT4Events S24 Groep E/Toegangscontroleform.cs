using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Phidgets;
using Phidgets.Events;

namespace ICT4Events_S24_Groep_E
{
    public partial class Toegangscontroleform : Form
    {
        //Field
        private Administratie administratie;
        private DatabaseKoppeling database;

        public Toegangscontroleform()
        {
            InitializeComponent();
            administratie = new Administratie();
            RefreshData(administratie.HuidigEvent);
            dataGridViewToegangAanwezig.AllowUserToAddRows = false;
            dataGridViewToegangAfwezig.AllowUserToAddRows = false;

        }

        //Event Handlers
        private void Toegangscontroleform_Load(object sender, EventArgs e)
        {
            
            try
            {
                RFID rfid = new RFID();
                rfid.Attach += new AttachEventHandler(rfid_Attach);
                rfid.Detach += new DetachEventHandler(rfid_Detach);
                rfid.Error += new ErrorEventHandler(rfid_Error);

                rfid.Tag += new TagEventHandler(rfid_Tag);
                rfid.TagLost += new TagEventHandler(rfid_TagLost);
                rfid.open();

                labelRFID.Text = "wachtend op RFID scanner...";
                rfid.waitForAttachment(3000);
            }
            catch (PhidgetException ex)
            {
                MessageBox.Show(ex.Description);
            }
        }
        private void rfid_Attach(object sender, AttachEventArgs e)
        {
            labelRFID.Text = "RFID Scanner " + e.Device.SerialNumber.ToString() + " is aangesloten!";
        }
        private void rfid_Detach(object sender, DetachEventArgs e)
        {
            labelRFID.Text = "RFID Scanner " + e.Device.SerialNumber.ToString() + " is losgekoppeld.";
        }

        private void rfid_Error(object sender, ErrorEventArgs e)
        {
            labelRFID.Text = e.Description;
        }

        private void rfid_Tag(object sender, TagEventArgs e)
        {
            labelRFID.Text = "RFID " + e.Tag + " gescand!";
        }

        private void rfid_TagLost(object sender, TagEventArgs e)
        {
            labelRFID.Text = "RFID " + e.Tag + " verloren!";
        }

        private void RefreshData(Event e)
        {
            int aantalaanwezig = 0;
            int aantalafwezig = 0;
            dataGridViewToegangAanwezig.Rows.Clear();
            dataGridViewToegangAfwezig.Rows.Clear();
            dataGridViewToegangAanwezig.Refresh();
            dataGridViewToegangAfwezig.Refresh();
            List<Persoon> personen = administratie.GeefEvent(e.Naam).Personen;
            foreach (Persoon persoon in personen)
            {
                if (persoon is Bezoeker)
                {
                    Bezoeker b = persoon as Bezoeker;
                    if (b.Aanwezig)
                    {
                        dataGridViewToegangAanwezig.Rows.Add(b.RfidCode, b.Naam, b.Achternaam,administratie.GeefPlaats(b,administratie.GeefEvent(e.Naam)));
                        aantalaanwezig++;
                    }
                    else
                    {
                        dataGridViewToegangAfwezig.Rows.Add(b.RfidCode, b.Naam, b.Achternaam,administratie.GeefPlaats(b,administratie.GeefEvent(e.Naam)));
                        aantalafwezig++;
                    }
                }
            }
            labelToegangAanwezig.Text = "Aanwezigen: (" + aantalaanwezig + " personen)";
            labelToegangAfwezig.Text = "Afwezigen: (" + aantalafwezig + " personen)";
        }

        private void buttonToegangCheckInUit_Click(object sender, EventArgs e)
        {
            if (administratie.CheckInUit(textBoxToegangRFID.Text, administratie.HuidigEvent))
            {
                RefreshData(administratie.HuidigEvent);
            }
            else
            {
                MessageBox.Show(@"In/Uitcheck is niet geslaagd");
            }
        }

        private void TerugNaarLogin(object sender, FormClosedEventArgs e)
        {

            if (administratie.NuIngelogd is Beheerder)
            {
                var systeemKiezerForm = new SysteemKiezerForm();
                systeemKiezerForm.Show();
                this.Hide();
            }
            if (administratie.NuIngelogd is Controleur)
            {
                var logInForm = new LoginForm();
                logInForm.Show();
                this.Hide();
            }
        }

        
    }
}
