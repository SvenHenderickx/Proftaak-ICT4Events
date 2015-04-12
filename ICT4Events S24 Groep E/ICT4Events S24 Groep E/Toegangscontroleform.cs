using ICT4Events;
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
        private Event sme;
        public Toegangscontroleform()
        {
            InitializeComponent();
            sme = new Event("Social Media Event", new DateTime(2015, 10, 3, 19, 00, 00), new DateTime(2015, 10, 4, 03, 00, 00), "Camping Reeëndal", "Wildeman 50");
            RefreshData();
        }

        private void RefreshData()
        {
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
            dataGridView1.Refresh();
            dataGridView2.Refresh();
            List<Persoon> personen = sme.Personen;
            foreach (Persoon persoon in personen)
            {
                if (persoon is Bezoeker)
                {
                    Bezoeker b = persoon as Bezoeker;
                    if (b.Aanwezig)
                    {
                        this.dataGridView1.Rows.Add(b.RfidCode, b.Naam, b.Achternaam);
                    }
                    else
                    {
                        this.dataGridView2.Rows.Add(b.RfidCode, b.Naam, b.Achternaam);
                    }
                }
            }
        }

        private void CheckIn(string rfid)
        {
            List<Persoon> personen = sme.Personen;
            foreach (Persoon persoon in personen)
            {
                if (persoon is Bezoeker)
                {
                    Bezoeker b = persoon as Bezoeker;
                    if (!b.Aanwezig)
                    {
                        b.Aanwezig = true;
                    }
                }
            }
        }
    }
}
