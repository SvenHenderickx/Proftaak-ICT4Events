using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICT4Events_S24_Groep_E
{
    public class Event
    {
        //Fields
        private string naam;
        private DateTime beginDatum;
        private DateTime eindDatum;
        private string plaats;
        private string adres;
        private List<Persoon> personen;
        private List<Plaats> plaatsen;
        private List<Huuritem> huurMateriaal;
        private List<Reservering> reserveringen;
        private List<Categorie> categorieen;
        private List<Bericht> berichten;
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

        public List<Huuritem> HuurMateriaal
        {
            get { return huurMateriaal; }
        }

        public List<Reservering> Reserveringen
        {
            get { return reserveringen; }
        }

        public List<Categorie> Categorieen
        {
            get { return categorieen; }
        }

        public List<Bericht> Berichten
        {
            get { return berichten; }
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
            huurMateriaal = new List<Huuritem>();
            TestDataHuurmateriaal();
            reserveringen = new List<Reservering>();
            categorieen = new List<Categorie>();
            berichten = new List<Bericht>();
        }

        //Methodes
        private void TestDataPersonen()
        {       
            // Beheerder aanmaken
            personen.Add(new Beheerder("Admin", "Admin", new DateTime(1996, 9, 27)));
            // Hoofdboeker aanmaken
            personen.Add(new Hoofdboeker("PeterSchepers", "SchepersPeter", new DateTime(1980, 5, 20), "162784929")); 
            // Bezoekers aanmaken
            personen.Add(new Bezoeker("HennyHanssen", "HanssenHenny", new DateTime(1996, 12, 15), GeefHoofdboeker("PeterSchepers")));
            personen.Add(new Bezoeker("AnjaHaas", "HaasAnja", new DateTime(1998, 3, 18), GeefHoofdboeker("PeterSchepers")));
            personen.Add(new Controleur("AlexRas", "RasAlex", new DateTime(1995, 5, 22)));
        }
        private void TestDataPlaatsen()
        {
            plaatsen.Add(new Plaats(100, GeefHoofdboeker("Peterschepers"), true, 8));
            plaatsen.Add(new Plaats(200, null, false, 10));
        }

        private void TestDataHuurmateriaal()
        {
            huurMateriaal.Add(new Huuritem("Canon 1024M", "Fotocamera"));
            huurMateriaal.Add(new Huuritem("Sony 800D", "Fotocamera"));
            huurMateriaal.Add(new Huuritem("LG B120", "Videocamera"));
            huurMateriaal.Add(new Huuritem("Samsung C800", "Videocamera"));

        }

        // Hoofdboeker kan worden opgezocht via gebuikersnaam
        private Hoofdboeker GeefHoofdboeker(string gebruikersNaam)
        {
            foreach (Persoon p in personen)
            {
                if (p is Hoofdboeker && p.Gebruikersnaam == gebruikersNaam)
                {
                    Hoofdboeker h = p as Hoofdboeker;
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

        public Persoon CheckGebruikersNaamRfid(string inv)
        {
            foreach (Persoon p in personen)
            {
                if (inv == p.Gebruikersnaam || inv == p.RfidCode)
                {
                    return p;
                }
            }
            return null;
        }

        public Huuritem GeefHuuritem(string itemNaam)
        {
            foreach (Huuritem h in huurMateriaal)
            {
                if (h.Naam == itemNaam)
                {
                    return h;
                }
            }
            return null;
        }

    }
}
