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
            database = new DatabaseKoppeling();
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

                labelRFID.Text = "wachtend op RFID scanner... U kunt altijd handmatig inchecken.";
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
            labelRFID.Text = "RFID Scanner " + e.Device.SerialNumber.ToString() + " is losgekoppeld. U kunt nog steeds handmatig inchecken.";
        }

        private void rfid_Error(object sender, ErrorEventArgs e)
        {
            labelRFID.Text = e.Description;
        }

        private void rfid_Tag(object sender, TagEventArgs e)
        {
            if (database.CheckInOut(e.Tag))
            {
                RefreshData(administratie.HuidigEvent);
                labelCheckInfo.Text = "Er is succesvol in of uitgecheckt door RFID " + e.Tag;
            }
            else
            {
                labelCheckInfo.Text = "In of uitchecken is niet geslaagd door RFID " + e.Tag;
            }
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
            foreach (Persoon persoon in database.HaalPersonenOp(e.Naam))
            {
                if (persoon is Bezoeker && !(persoon is Hoofdboeker))
                {
                    Bezoeker b = persoon as Bezoeker;
                    if (b.Aanwezig)
                    {
                        dataGridViewToegangAanwezig.Rows.Add(b.RfidCode, b.Naam, b.Achternaam);
                        aantalaanwezig++;
                    }
                    else
                    {
                        dataGridViewToegangAfwezig.Rows.Add(b.RfidCode, b.Naam, b.Achternaam);
                        aantalafwezig++;
                    }
                }
            }
            labelToegangAanwezig.Text = "Aanwezigen: (" + aantalaanwezig + " personen)";
            labelToegangAfwezig.Text = "Afwezigen: (" + aantalafwezig + " personen)";
        }

        private void buttonToegangCheckInUit_Click(object sender, EventArgs e)
        {
            if (database.CheckInOut(textBoxToegangRFID.Text))
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
