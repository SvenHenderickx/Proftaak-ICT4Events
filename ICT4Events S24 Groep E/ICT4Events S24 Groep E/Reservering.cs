using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICT4Events_S24_Groep_E
{
    class Reservering
    {
        private string status;

        public string Status
        {
            get { return status; }
        }

        public Reservering(Hoofdboeker hoofdboeker)
        {

        }

        public bool HuurMateriaal(Huuritem huuritem)
        {
            // Als het huuritem nog niet gehuurd is, moet deze bij een persoon aan de lijst hehuurd toegevoegd worden.
            // bool isgehuurd wordt true.
            
        }
    }
}
