using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICT4Events_S24_Groep_E
{
    public class Bericht
    {
        private int likes;
        private int aantalKeerGerapporteerd;
        private string tekst;
        private List<Reactie> reacties;
        private Persoon auteur;

        public int Likes
        {
            get { return likes; }
        }

        public int AantalKeerGerapporteerd
        {
            get { return aantalKeerGerapporteerd; }
        }

        public string Tekst
        {
            get { return tekst; }
        }

        public List<Reactie> Reacties
        {
            get { return reacties; }
        }

        public Persoon Auteur
        {
            get { return auteur; }
        }

        public Bericht(string tekst, Persoon auteur)
        {
            this.tekst = tekst;
            this.auteur = auteur;
            reacties = new List<Reactie>();
        }
    }
}
