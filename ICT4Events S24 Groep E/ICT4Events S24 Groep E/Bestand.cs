using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICT4Events_S24_Groep_E
{
    public class Bestand
    {
        //Fields
        private string naam;
        private Persoon maker;
        private int likes;
        private string pad;
        private int aantalKeerGerapporteerd;
        private int aantalKeerBekeken;
        private List<Reactie> reacties;

        //Properties
        public string Naam
        {
            get { return naam; }
        }

        public Persoon Maker
        {
            get { return maker; }
        }

        public int Likes
        {
            get { return likes; }
        }

        public string Pad
        {
            get { return pad; }
        }

        public int AantalKeerGerapporteerd
        {
            get { return aantalKeerGerapporteerd; }
        }

        public int AantalKeerBekeken
        {
            get { return aantalKeerBekeken; }
        }

        public List<Reactie> Reacties
        {
            get { return reacties; }
        }

        //Constructor
        public Bestand(Bezoeker bezoeker, Categorie categorie, string naam, string pad)
        {
            this.naam = naam;
            this.pad = pad;
            reacties = new List<Reactie>();
        }

        //Methodes
        //Met deze methode kun je een reactie toevoegen
        public bool VoegReactieToe(Reactie reactie)
        {
            bool succes = true;
            foreach (Reactie r in reacties)
            {
                if (r.Reactienummer == reactie.Reactienummer)
                {
                    succes = false;
                }
            }
            if (succes)
            {
                reacties.Add(reactie);
            }
            return succes;
        }

        //Deze methode wordt gebruikt om een reactie te verwijderen
        public void VerwijderReactie(Reactie reactie)
        {
            foreach (Reactie r in reacties)
            {
                if (reactie == r)
                {
                    reacties.Remove(reactie);
                }
            }
        }
    }
}
