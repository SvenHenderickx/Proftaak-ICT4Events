using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICT4Events_S24_Groep_E
{
    public class Rapportage
    {
        private Persoon rapporteur;
        private string reden;

        public Persoon Rapporteur
        {
            get { return rapporteur; }
        }

        public string Reden
        {
            get { return reden; }
        }

        public Rapportage(string reden, Persoon rapporteur)
        {
            this.reden = reden;
            this.rapporteur = rapporteur;
        }

        public string ToString()
        {
            return rapporteur.Gebruikersnaam + ": " + reden;
        }
    }
}
