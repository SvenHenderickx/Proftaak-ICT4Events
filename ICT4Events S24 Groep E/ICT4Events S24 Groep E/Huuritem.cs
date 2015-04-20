using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICT4Events_S24_Groep_E
{
    public class Huuritem
    {
        //Fields
        private string naam;
        private string type;
        private bool isGehuurd;

        //Methodes
        public string Naam
        {
            get { return naam; }
        }

        public string Type
        {
            get { return type; }
        }

        public bool IsGehuurd
        {
            get { return isGehuurd; }
            set { isGehuurd = value; }
        }

        //Constructor
        public Huuritem(string naam, string type)
        {
            this.naam = naam;
            this.type = type;
            isGehuurd = false;
        }
    }
}
