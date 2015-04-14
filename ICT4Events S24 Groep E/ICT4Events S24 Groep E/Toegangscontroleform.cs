//using ICT4Events; Frank: Dit stond er nog van het vorige project
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
    public partial class Toegangscontroleform : Form
    {
        private Administratie administratie;
        public Toegangscontroleform()
        {
            InitializeComponent();
            administratie = new Administratie();
            RefreshCombobox();
            comboBoxToegangEvents.SelectedIndex = 0;
            RefreshData(administratie.GeefEvent(comboBoxToegangEvents.Text));
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
            labelToegangAanwezig.Text = "Aanwezig: (" + aantalaanwezig + " personen)";
            labelToegangAfwezig.Text = "Afwezig: (" + aantalafwezig + " personen)";
        }

        private void RefreshCombobox()
        {
            foreach (Event e in administratie.Events)
            {
                comboBoxToegangEvents.Items.Add(e.Naam);
            }
        }

        private void comboBoxToegangEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshData(administratie.GeefEvent(comboBoxToegangEvents.Text));
        }
    }
}
