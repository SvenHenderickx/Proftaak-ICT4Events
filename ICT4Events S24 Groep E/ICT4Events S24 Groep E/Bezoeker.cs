using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICT4Events
{
    class Bezoeker : Persoon
    {
        //Fields
        protected bool aanwezig = false;
        private Hoofdboeker hoofdboeker;

        //Properties
        public bool Aanwezig
        {
            get { return aanwezig; }
            set { aanwezig = value; }
        }

        //Constructor

        public Bezoeker(string gebruikersnaam, string wachtwoord, DateTime geboortedatum)
            : base(gebruikersnaam, wachtwoord, geboortedatum)
        {
            this.aanwezig = false;
            this.hoofdboeker = null; //de hoofdboeker is hijzelf
        }

        public Bezoeker(string gebruikersnaam, string wachtwoord, DateTime geboortedatum, Hoofdboeker hoofdboeker)
            : base(gebruikersnaam, wachtwoord, geboortedatum)
        {
            this.aanwezig = false;
            this.hoofdboeker = hoofdboeker;
        }

        //Methodes

    }
}
