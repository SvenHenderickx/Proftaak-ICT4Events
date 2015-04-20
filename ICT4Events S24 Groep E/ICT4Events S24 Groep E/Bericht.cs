using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICT4Events_S24_Groep_E
{
    public class Bericht : IComparable<Bericht>
    {
        //Fields
        private List<Like> likes;
        private List<Rapportage> rapportages;
        private string tekst;
        private List<Reactie> reacties;
        private Persoon auteur;
        private DateTime datumGepost;

        //Properties
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

        //Constructor
        public Bericht(string tekst, Persoon auteur)
        {
            this.tekst = tekst;
            this.auteur = auteur;
            datumGepost = DateTime.Now;
            reacties = new List<Reactie>();
            likes = new List<Like>();
            rapportages = new List<Rapportage>();
        }

        //Methodes
        public override string ToString()
        {
            return auteur.Gebruikersnaam + " " + datumGepost.ToString() + " : " + tekst;
        }

        //Met deze persoon kun je een bericht liken
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

        //Met deze methode kun je een reactie toevoegen
        public void ReactieToevoegen(string tekst, Persoon plaatser)
        {
            reacties.Add(new Reactie(plaatser, tekst));
        }

        //Deze methode rapporteerd berichten of posts
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

        //Deze methode sorteert berichten datum
        public int CompareTo(Bericht other)
        {
            if (datumGepost > other.DatumGepost)
            {
                return -1;
            }
            else if (datumGepost < other.DatumGepost)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        //Deze methode zoekt naar een reactie m.b.v. de ToString methode
        public Reactie ReactieZoekenMetToString(string inv)
        {
            foreach (Reactie r in reacties)
            {
                if (r.ToString() == inv)
                {
                    return r;
                }
            }
            return null;
        }

        //Deze methode verwijderd een reactie
        public void ReactieVerwijder(Reactie reactie)
        {
            foreach (Reactie r in reacties)
            {
                if (r == reactie)
                {
                    reacties.Remove(r);
                    return;
                }
            }
        }
    }
}
