using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICT4Events_S24_Groep_E
{
    class Reactie
    {
        private int reactienummer;
        private Bezoeker bezoeker;
        private string inhoud;
        private bool gerapporteerd;

        public int Reactienummer
        {
            get { return reactienummer; }
        }

        public Bezoeker Bezoeker
        {
            get { return bezoeker; }
        }

        public string Inhoud
        {
            get {return inhoud;}
        }

        public bool Gerapporteerd
        {
            get { return gerapporteerd; }
        }

        public Reactie(Bezoeker bezoeker, string inhoud)
        {
            this.inhoud = inhoud;
        }
    }
}
