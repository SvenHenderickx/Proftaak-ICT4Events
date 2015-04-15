using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICT4Events_S24_Groep_E
{
    class Controleur : Persoon
    {
        public Controleur(string gebruikersnaam, string wachtwoord, DateTime geboorteDatum, string naam, string achternaam)
            : base(gebruikersnaam, wachtwoord, geboorteDatum, naam, achternaam)
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
