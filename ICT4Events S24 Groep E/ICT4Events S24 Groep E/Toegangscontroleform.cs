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
            //RefreshData();
        }

        private void RefreshData(Event e)
        {
            int aanwezig = 0;
            int afwezig = 0;
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
                        this.dataGridViewToegangAanwezig.Rows.Add(b.RfidCode, b.Naam, b.Achternaam);
                        aanwezig++;
                    }
                    else
                    {
                        this.dataGridViewToegangAfwezig.Rows.Add(b.RfidCode, b.Naam, b.Achternaam);
                        afwezig++;
                    }
                }
            }
            labelToegangAanwezig.Text = "Aanwezig: (" + aanwezig + " personen)";
            labelToegangAfwezig.Text = "Afwezig: (" + afwezig + " personen)";
        }
    }
}
