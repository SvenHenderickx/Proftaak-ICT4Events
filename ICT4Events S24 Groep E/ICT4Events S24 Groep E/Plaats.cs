using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICT4Events_S24_Groep_E
{
    public class Plaats
    {
        // Fields
        private static int plaatsNummerTeller = 0;
        private string plaatsNummer;
        private int prijs;
        private Hoofdboeker huurder;
        private bool geluidsOverlast;
        private int aantalPersonen;
        private bool bezet;


        public string PlaatsNummer
        {
            get { return plaatsNummer; }
        }

        public int AantalPersonen
        {
            get { return aantalPersonen; }
        }

        public bool Bezet
        {
            get { return bezet; }
            set { bezet = value; }
        }

        public Hoofdboeker Huurder
        {
            get { return huurder; }
        }

        public int Prijs
        {
            get { return prijs; }
        }
        public Plaats(int prijs, Hoofdboeker huurder, bool geluidsOverlast, int aantalPersonen)
        {
            this.prijs = prijs;
            this.huurder = huurder;
            this.geluidsOverlast = geluidsOverlast;
            this.aantalPersonen = aantalPersonen;
            this.plaatsNummer = PlaatsNummerGenerator();
        }

        public override string ToString()
        {
            string geluidsOV = "nee";
            if (this.geluidsOverlast) geluidsOV = "ja";
            return "PlaatsNr: " + this.plaatsNummer + ", " + "Aantal Personen " + this.aantalPersonen + ", geluidsoverlast: " + geluidsOV;
        }

        private string PlaatsNummerGenerator()
        {
            // 1 ophogen bij een nieuwe plaats
            plaatsNummerTeller++;
            plaatsNummer = plaatsNummerTeller.ToString();
            while (plaatsNummer.Length < 4)
            {
                plaatsNummer = "0" + plaatsNummer;
            }
            return plaatsNummer;
        }
    }
}
