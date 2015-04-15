using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICT4Events_S24_Groep_E
{
    public class Bericht
    {
        private List<Like> likes;
        private int aantalKeerGerapporteerd;
        private string tekst;
        private List<Reactie> reacties;
        private Persoon auteur;
        private DateTime datumGepost;

        public List<Like> Likes
        {
            get { return likes; }
        }

        public int AantalKeerGerapporteerd
        {
            get { return aantalKeerGerapporteerd; }
        }

        public DateTime DatumGepost
        {
            get { return datumGepost; }
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
            datumGepost = DateTime.Now;
            reacties = new List<Reactie>();
            likes = new List<Like>();
        }

        public string ToString()
        {
            return likes.Count + " Like(s): " + tekst + " - " + datumGepost;
        }

        public bool BerichtLiken(Persoon invPersoon)
        {
            foreach (Like l in likes)
            {
                if (invPersoon == l.Liker)
                {
                    return false;
                }
            }
            likes.Add(new Like(invPersoon));
            return true;
        }

        public void ReactieToevoegen(string tekst, Persoon plaatser)
        {
            reacties.Add(new Reactie(plaatser, tekst));
        }
    }
}
