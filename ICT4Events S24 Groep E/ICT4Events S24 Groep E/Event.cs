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
            get { return new List<Persoon>(personen); }
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
        }

        //Methodes

    }
}
