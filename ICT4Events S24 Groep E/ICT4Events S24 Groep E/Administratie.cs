using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICT4Events_S24_Groep_E
{
    class Administratie
    {
        // Fields
        private List<Event> events;

        public Administratie()
        {
            events = new List<Event>();
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
    }
}
