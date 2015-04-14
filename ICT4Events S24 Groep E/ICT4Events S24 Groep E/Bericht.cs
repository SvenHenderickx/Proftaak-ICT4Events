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
        private int aantalKeerBekeken;
        private string tekst;
        private List<Reactie> reacties;

        public int Likes
        {
            get { return likes; }
        }

        public int AantalKeerGerapporteerd
        {
            get { return aantalKeerGerapporteerd; }
        }

        public int AantalKeerBekeken
        {
            get { return aantalKeerBekeken; }
        }

        public string Tekst
        {
            get { return tekst; }
        }

        public List<Reactie> Reacties
        {
            get { return reacties; }
        }

        public Bericht(string tekst)
        {
            this.tekst = tekst;
            reacties = new List<Reactie>();
        }
    }
}
