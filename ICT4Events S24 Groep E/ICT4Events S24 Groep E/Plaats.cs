using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICT4Events_S24_Groep_E
{
    class Plaats
    {
        // Fields
        private static int plaatsNummerTeller = 1;
        private int plaatsNummer;
        private int prijs;
        private Bezoeker huurder;
        private bool geluidsOverlast;
        private int aantalPersonen;

        public Plaats(int prijs, Bezoeker huurder, bool geluidsOverlast, int aantalPersonen)
        {
            this.prijs = prijs;
            this.huurder = huurder;
            this.geluidsOverlast = geluidsOverlast;
            this.aantalPersonen = aantalPersonen;
            this.plaatsNummer = plaatsNummerTeller;
            plaatsNummerTeller++; // automatisch 1 ophogen voor een nieuwe plaats 
        }
    }
}
