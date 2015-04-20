using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICT4Events_S24_Groep_E
{
    public class Bestand
    {
        //private string naam;
        //private Persoon maker;
        //private int likes;
        private string pad;
        //private int aantalKeerGerapporteerd;
        //private int aantalKeerBekeken;
        //private List<Reactie> reacties;

        public string Pad
        {
            get { return pad; }
        }

        public Bestand(string pad)
        {
            this.pad = pad;
        }
    }
}
