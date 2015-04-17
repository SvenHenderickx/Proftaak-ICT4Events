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
        private List<Rapportage> rapportages;
        private string tekst;
        private List<Reactie> reacties;
        private Persoon auteur;
        private DateTime datumGepost;

        public List<Like> Likes
        {
            get { return likes; }
        }

        public List<Rapportage> Rapportages
        {
            get { return rapportages; }
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
            rapportages = new List<Rapportage>();
        }

        public override string ToString()
        {
            return auteur.Gebruikersnaam + " " + datumGepost.ToString() + " : " + tekst;
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

        public bool Rapporteren(string reden, Persoon rapporteur)
        {
            foreach (Rapportage r in rapportages)
            {
                if (r.Rapporteur == rapporteur)
                {
                    return false;
                }
            }
            rapportages.Add(new Rapportage(reden, rapporteur));
            return true;
        }
    }
}
