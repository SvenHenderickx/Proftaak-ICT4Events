using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICT4Events_S24_Groep_E
{
    public class Hoofdboeker : Bezoeker
    {
        //Fields
        private string rekeningNummer;

        //Constructor
        public Hoofdboeker(string gebruikersnaam, string wachtwoord, DateTime geboorteDatum, string rekeningNummer, string naam, string achternaam, bool aanwezig)
            : base(gebruikersnaam, wachtwoord, geboorteDatum, naam, achternaam, aanwezig)
        {
            this.rekeningNummer = rekeningNummer;
        }

        public Hoofdboeker(string gebruikersnaam, string wachtwoord, DateTime geboorteDatum, string rekeningNummer, string naam, string achternaam, bool aanwezig, string rfid)
            : base(gebruikersnaam, wachtwoord, geboorteDatum, naam, achternaam, aanwezig, rfid)
        {
            this.rekeningNummer = rekeningNummer;
        }

        //Methods
        public override string ToString()
        {
            return base.ToString();
        }

    }
}
