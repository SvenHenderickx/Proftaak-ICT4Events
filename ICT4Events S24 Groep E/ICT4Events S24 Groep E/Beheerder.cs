using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICT4Events_S24_Groep_E
{
    public class Beheerder : Persoon
    {
        //Constructors
        public Beheerder(string gebruikersnaam, string wachtwoord, DateTime geboorteDatum, string naam, string achternaam)
            : base(gebruikersnaam, wachtwoord, geboorteDatum, naam, achternaam)
        {

        }

        public Beheerder(string gebruikersnaam, string wachtwoord, DateTime geboorteDatum, string naam, string achternaam, string rfid)
            : base(gebruikersnaam, wachtwoord, geboorteDatum, naam, achternaam, rfid)
        {

        }

        //Methodes
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
