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
        private List<Bestand> bestanden;
        private List<Categorie> categorieen;

        public string Naam
        {
            get { return naam; }
        }

        public List<Bestand> Bestanden
        {
            get { return bestanden; }
        }

        public List<Categorie> Categorieen
        {
            get { return categorieen; }
        }

        public Categorie(Bezoeker bezoeker, string naam)
        {
            this.naam = naam;
            bestanden = new List<Bestand>();
            categorieen = new List<Categorie>();
        }

        public bool VoegBestandToe(Bestand bestand)
        {
            bool succes = true;
            foreach (Bestand b in bestanden)
            {
                if (b.Pad == bestand.Pad)
                {
                    succes = false;
                }
            }
            if (succes)
            {
                bestanden.Add(bestand);
            }
            return succes;
        }
    }
}
