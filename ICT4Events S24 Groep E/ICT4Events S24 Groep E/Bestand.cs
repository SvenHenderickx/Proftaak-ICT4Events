﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICT4Events_S24_Groep_E
{
    class Bestand
    {
        private string naam;
        private Persoon maker;
        private int likes;
        private string pad;
        private int aantalKeerGerapporteerd;
        private int aantalKeerBekeken;
        private List<Reactie> reacties;

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

        public Bestand(Bezoeker bezoeker, Categorie categorie, string naam, string pad)
        {
            this.naam = naam;
            this.pad = pad;
            reacties = new List<Reactie>();
        }

        public bool VoegReactieToe(Reactie reactie)
        {
<<<<<<< HEAD
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
=======
<<<<<<< HEAD
<<<<<<< HEAD
            return false;
=======
            return true;
>>>>>>> origin/master
=======

>>>>>>> parent of 6da9a56... fout
>>>>>>> origin/master
        }

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
