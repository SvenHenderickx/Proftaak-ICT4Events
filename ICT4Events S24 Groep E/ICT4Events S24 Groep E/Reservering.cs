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
        private List<Plaats> plaatsen;

        public string Status
        {
            get { return status; }
        }

        public List<Plaats> Plaatsen
        {
            get { return plaatsen; }
        }

        public Reservering(Hoofdboeker hoofdboeker)
        {
            plaatsen = new List<Plaats>();
        }

        public bool HuurMateriaal(Huuritem huuritem)
        {
            // Als het huuritem nog niet gehuurd is, moet deze bij een persoon aan de lijst hehuurd toegevoegd worden.
            // bool isgehuurd wordt true.
            
        }
    }
}
