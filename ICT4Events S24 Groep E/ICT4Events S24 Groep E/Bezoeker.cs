using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICT4Events_S24_Groep_E
{
    public class Bezoeker : Persoon
    {
        //Fields
        protected bool aanwezig = false;
        private Hoofdboeker hoofdboeker;
        private List<Huuritem> huurMateriaal;

        //Properties
        public bool Aanwezig
        {
            get { return aanwezig; }
            set { aanwezig = value; }
        }

        public Hoofdboeker Hoofdboeker
        {
            get { return hoofdboeker; }
        }

        public List<Huuritem> HuurMateriaal
        {
            get { return huurMateriaal; }
            set { huurMateriaal = value; }
        }

        //Constructor

        public Bezoeker(string gebruikersnaam, string wachtwoord, DateTime geboortedatum)
            : base(gebruikersnaam, wachtwoord, geboortedatum)
        {
            this.aanwezig = false;
            this.hoofdboeker = null; //de hoofdboeker is hijzelf
            huurMateriaal = new List<Huuritem>();
        }

        public Bezoeker(string gebruikersnaam, string wachtwoord, DateTime geboortedatum, Hoofdboeker hoofdboeker)
            : base(gebruikersnaam, wachtwoord, geboortedatum)
        {
            this.aanwezig = false;
            this.hoofdboeker = hoofdboeker;
            huurMateriaal = new List<Huuritem>();
        }

        //Methodes
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
