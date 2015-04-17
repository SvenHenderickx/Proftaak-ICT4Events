using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICT4Events_S24_Groep_E
{
    public class Reactie
    {
        private static int reactienummer;
        private Persoon plaatser;
        private string inhoud;
        private bool gerapporteerd;
        private DateTime datumGeplaatst;

        public int Reactienummer
        {
            get { return reactienummer; }
        }

        public Persoon Plaatser
        {
            get { return plaatser; }
        }

        public string Inhoud
        {
            get { return inhoud; }
        }

        public DateTime DatumGeplaatst
        {
            get { return datumGeplaatst; }
        }

        public bool Gerapporteerd
        {
            get { return gerapporteerd; }
        }

        public Reactie(Persoon plaatser, string inhoud)
        {
            gerapporteerd = false;
            datumGeplaatst = DateTime.Now;
            this.plaatser = plaatser;
            this.inhoud = inhoud;
        }

        public string ToString()
        {
            return plaatser.Gebruikersnaam + ": " + inhoud;
        }
    }
}
