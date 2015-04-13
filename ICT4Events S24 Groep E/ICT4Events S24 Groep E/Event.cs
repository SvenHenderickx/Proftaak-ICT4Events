using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICT4Events_S24_Groep_E
{
    class Event
    {
        //Fields
        private string naam;
        private DateTime beginDatum;
        private DateTime eindDatum;
        private string plaats;
        private string adres;
        private List<Persoon> personen;
        private List<Plaats> plaatsen;
        //private Beheerder!

        //Properties
        public string Naam
        {
            get { return naam; }
        }

        public DateTime BeginDatum
        {
            get { return beginDatum; }
        }

        public DateTime EindDatum
        {
            get { return eindDatum; }
        }

        public string Plaats
        {
            get { return plaats; }
        }

        public string Adres
        {
            get { return adres; }
        }
        public List<Persoon> Personen
        {
            get { return new List<Persoon>(personen); } // Frank: moet hier een nieuwe lijst gereturnd worden?
        }

        public List<Plaats> Plaatsen
        {
            get { return plaatsen; }
        }

        //Constructors
        public Event(string naam, DateTime beginDatum, DateTime eindDatum, string plaats, string adres)
        {
            this.naam = naam;
            this.beginDatum = beginDatum;
            this.eindDatum = eindDatum;
            this.plaats = plaats;
            this.adres = adres;
            personen = new List<Persoon>();
            TestDataPersonen();
            plaatsen = new List<Plaats>();
            TestDataPlaatsen();
        }

        //Methodes
        private void TestDataPersonen()
        {          
            // Hoofdboeker aanmaken
            personen.Add(new Hoofdboeker("PeterSchepers", "SchepersPeter", new DateTime(1980, 5, 20), "162784929")); 
            // Bezoekers aanmaken
            personen.Add(new Bezoeker("HennyHanssen", "HanssenHenny", new DateTime(1996, 12, 15), GeefHoofdboeker("PeterSchepers")));
            personen.Add(new Bezoeker("AnjaHaas", "HaasAnja", new DateTime(1998, 3, 18), GeefHoofdboeker("PeterSchepers")));
        }
        private void TestDataPlaatsen()
        {
            plaatsen.Add(new Plaats(100, GeefHoofdboeker("Peterschepers"), true, 8));
            plaatsen.Add(new Plaats(200, null, false, 10));
        }

        // Hoofdboeker kan worden opgezocht via gebuikersnaam
        private Hoofdboeker GeefHoofdboeker(string gebruikersNaam)
        {
            foreach (Hoofdboeker h in personen)
            {
                if (h.Gebruikersnaam == gebruikersNaam)
                {
                    return h;
                }
            }
            return null;
        }

        public Plaats GeefPlaats(string plaatsNummer)
        {
            foreach (Plaats p in plaatsen)
            {
                if (p.PlaatsNummer == plaatsNummer)
                {
                    return p;
                }
            }
            return null;
        }

    }
}
