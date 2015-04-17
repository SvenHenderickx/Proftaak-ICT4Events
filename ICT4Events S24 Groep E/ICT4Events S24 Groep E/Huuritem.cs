using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICT4Events_S24_Groep_E
{
    public class Huuritem
    {
        private string naam;
        private string type;
        private bool isGehuurd;

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

        public Huuritem(string naam, string type)
        {
            this.naam = naam;
            this.type = type;
            isGehuurd = false;
        }
    }
}
