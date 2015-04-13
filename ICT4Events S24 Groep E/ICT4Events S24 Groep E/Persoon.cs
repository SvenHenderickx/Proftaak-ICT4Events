using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICT4Events_S24_Groep_E
{
    abstract class Persoon
    {
        //Fields
        protected static int lastRfidCode = 0;
        protected string rfidCode;
        protected string gebruikersnaam;
        protected string naam;
        protected string achternaam;
        protected DateTime geboorteDatum;
        protected string wachtwoord;

        //Properties
        public string RfidCode
        {
            get { return rfidCode; }
        }

        public string Gebruikersnaam
        {
            get { return gebruikersnaam; }
        }

        public string Naam
        {
            get { return naam; }
        }
        public string Achternaam
        {
            get { return achternaam; }
        }
        public DateTime GeboorteDatum
        {
            get { return geboorteDatum; }
        }

        //Constructors

        public Persoon(string gebruikersnaam, string wachtwoord, DateTime geboorteDatum)
        {
            this.gebruikersnaam = gebruikersnaam;
            this.wachtwoord = wachtwoord;
            this.geboorteDatum = geboorteDatum;
            RfidGenerator();
        }

        private string RfidGenerator()
        {
            lastRfidCode++;
            rfidCode = lastRfidCode.ToString();
            while (rfidCode.Length < 6)
            {
                rfidCode = "0" + rfidCode;
            }
            return rfidCode;
        }

        public bool CheckWachtwoord(string invWachtwoord)
        {
            if (invWachtwoord == wachtwoord)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
