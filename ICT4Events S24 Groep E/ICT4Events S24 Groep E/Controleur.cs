using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICT4Events_S24_Groep_E
{
    class Controleur : Persoon
    {
        //Constructor
        public Controleur(string gebruikersnaam, string wachtwoord, DateTime geboorteDatum, string naam, string achternaam,string rfidcode)
            : base(gebruikersnaam, wachtwoord, geboorteDatum, naam, achternaam,rfidcode)
        {

        }

        public Controleur(string gebruikersnaam, string wachtwoord, DateTime geboorteDatum, string naam, string achternaam, string rfid)
            : base(gebruikersnaam, wachtwoord, geboorteDatum, naam, achternaam, rfid)
        {

        }

        //Methode
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
