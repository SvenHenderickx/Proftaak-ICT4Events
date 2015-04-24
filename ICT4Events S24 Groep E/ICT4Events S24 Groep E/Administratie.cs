﻿using System;
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
        private static DatabaseKoppeling databaseKoppeling;
        protected static int lastRfidCode = 0;

        //Properties
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

        public DatabaseKoppeling DatabaseKoppeling
        {
            get { return databaseKoppeling; }
            set { databaseKoppeling = value; }
        }

        // Constructor
        public Administratie()
        {
            if (countGemaakt == 0)
            {

            }
            countGemaakt++;
            databaseKoppeling = new DatabaseKoppeling();
        }

        //Methodes
       

        //Deze methode zoekt naar bestaande events
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

        //Met deze methode kun je een bezoeker in- en uitchecken
        public bool CheckInUit(string rfid, Event e)
        {
            List<Persoon> personen = e.Personen;

            foreach (Persoon persoon in databaseKoppeling.HaalPersonenOp(HuidigEvent.Naam))
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

        //Met deze methode worden gebruikers opgevraagd uit een event
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

        //Met deze methode kun je de plaats(en) van een bezoeker opvragen
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

        //Deze methode wordt gebruikt om een event toe te voegen
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

        //Deze methode kijkt of de ingevoerde data alleen uit getallen bestaat
        public bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                {
                    return false;
                }
                    
            }

            return true;
        }

        public void HaalAlleEventsOp()
        {
            events.Clear();
            List<Event> tempEvent = new List<Event>();
            tempEvent = databaseKoppeling.HaalAlleEvenementen();
            foreach (Event e in tempEvent)
            {
                events.Add(e);
            }
        }

        public void VoegAlleGebruikersToeAanEvent(string eventNaam)
        {
            foreach (Event e in events)
            {
                if (eventNaam == e.Naam)
                {
                    e.Personen.Clear();
                    e.VoegPersonenToe(databaseKoppeling.HaalPersonenOp(e.Naam));
                }
            }
        }

<<<<<<< HEAD
        public void VraagAlleBerichtenOp(string eventNaam)
        {
            huidigEvent.Berichten.Clear();
            huidigEvent.VoegBerichtenToe(databaseKoppeling.VraagBerichtenOpVanEvent(eventNaam));
=======
        public string RfidGenerator()
        {
            lastRfidCode++;
            string rfidCode = "";
            rfidCode = lastRfidCode.ToString();
            while (rfidCode.Length < 6)
            {
                rfidCode = "0" + rfidCode;
            }
            return rfidCode;
>>>>>>> origin/master
        }
    }
}
