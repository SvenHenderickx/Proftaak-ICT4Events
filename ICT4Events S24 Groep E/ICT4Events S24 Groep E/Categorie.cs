using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICT4Events_S24_Groep_E
{
    class Categorie
    {
        private string naam;

        public string Naam
        {
            get { return naam; }
        }

        public Categorie(Bezoeker bezoeker, string naam)
        {
            this.naam = naam;
        }

        public bool VoegBestandToe()
        {

        }
    }
}
