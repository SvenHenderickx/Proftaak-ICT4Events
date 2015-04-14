using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICT4Events_S24_Groep_E
{
    public class Administratie
    {
        // Fields
        private static List<Event> events = new List<Event>();

        public List<Event> Events
        {
            get { return events; }
        }

        public Administratie()
        {
            TestDataEvents();
        }

        private void TestDataEvents()
        {
            events.Add(new Event("SME Event", new DateTime(2015, 6, 18), new DateTime(2015, 6, 25), "Eindhoven", "Woensel 12"));
        }

        public Event GeefEvent(string eventNaam)
        {
            foreach (Event e in events)
            {
                if (e.Naam == eventNaam)
                {
                    return e;
                }
            }
            return null;
        }

        private void CheckIn(string rfid, Event e)
        {
            List<Persoon> personen = e.Personen;

            foreach (Persoon persoon in personen)
            {
                if (persoon is Bezoeker)
                {
                    Bezoeker b = persoon as Bezoeker;
                    if (b.RfidCode == rfid)
                    {
                        if (!b.Aanwezig)
                        {
                            b.Aanwezig = true;
                        }
                    }
                }
            }
        }

<<<<<<< HEAD
        public Persoon CheckGebruikersInEvent(string inv)
        {
            foreach (Event e in events)
            {
                if (e.CheckGebruikersNaamRfid(inv) != null)
                {
                    return e.CheckGebruikersNaamRfid(inv);
                }
            }
            return null;
=======
        public string GeefPlaats(Bezoeker b, Event e)
        {
            foreach (Plaats p in e.Plaatsen)
            {
                if (p.Huurder == b.Hoofdboeker)
                {
                    return p.PlaatsNummer;
                }
            }
            return "";
>>>>>>> origin/master
        }
    }
}
