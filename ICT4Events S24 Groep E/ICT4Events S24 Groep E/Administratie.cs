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
    }
}
