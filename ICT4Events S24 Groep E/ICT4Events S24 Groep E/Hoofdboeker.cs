using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICT4Events
{
    class Hoofdboeker : Bezoeker
    {
        //Fields
        private string rekeningNummer;

        //Constructor
        public Hoofdboeker(string gebruikersnaam, string wachtwoord, DateTime geboorteDatum, string rekeningNummer)
            : base(gebruikersnaam, wachtwoord, geboorteDatum)
        {
            this.rekeningNummer = rekeningNummer;
        }

        //Methods


    }
}
