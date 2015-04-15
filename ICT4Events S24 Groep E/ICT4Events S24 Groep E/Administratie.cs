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
        private static Persoon nuIngelogd = null;
        private static Event huidigEvent = null;
        private static Bericht tempBericht = null;
        private static int countGemaakt = 0;

        public List<Event> Events
        {
            get { return events; }
        }

        public Persoon NuIngelogd
        {
            get { return nuIngelogd; }
            set { nuIngelogd = value; }
        }

        public Bericht TempBericht
        {
            get { return tempBericht; }
            set { tempBericht = value; }
        }

        public Event HuidigEvent
        {
            get { return huidigEvent; }
            set { huidigEvent = value; }
        }

        // Constructor
        public Administratie()
        {
            if (countGemaakt == 0)
            {
                TestDataEvents();
            }
            countGemaakt++;
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

        public bool CheckInUit(string rfid, Event e)
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
                            return true;
                        }
                        else
                        {
                            b.Aanwezig = false;
                            return true;
                        }
                    }
                }
            }
            return false;
        }

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

        }

        public string GeefPlaats(Bezoeker b, Event e)
        {
            string plaatsen = "";
            foreach (Plaats p in e.Plaatsen)
            {
                if (p.Huurder == b.Hoofdboeker || p.Huurder == b as Hoofdboeker)
                {
                    if (p.Huurder != null)
                    {
                        if (plaatsen == "")
                        {
                            plaatsen = p.PlaatsNummer;
                        }
                        else
                        {
                            plaatsen = plaatsen + ", " + p.PlaatsNummer;
                        }
                    }
                    
                }
            }

            if (plaatsen != "")
            {
                return plaatsen;
            }
            return "";
        }

        public bool VoegEventToe(string naam, DateTime beginDatum, DateTime eindDatum, string plaats, string adres)
        {
            foreach (Event e in events)
            {
                if(naam == e.Naam)
                {
                    return false;
                }
            }
            events.Add(new Event(naam, beginDatum, eindDatum, plaats, adres));
            return true;
        }
    }
}
