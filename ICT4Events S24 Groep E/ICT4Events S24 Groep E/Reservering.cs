using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICT4Events_S24_Groep_E
{
    public class Reservering
    {
        private string status;
        private List<Plaats> plaatsen;
        private Hoofdboeker hoofdboeker;

        public string Status
        {
            get { return status; }
        }

        public List<Plaats> Plaatsen
        {
            get { return plaatsen; }
        }

        public Reservering(Hoofdboeker hoofdboeker, List<Plaats> plaatsen)
        {
            this.hoofdboeker = hoofdboeker;
            this.plaatsen = plaatsen;
        }

        public bool HuurMateriaal(Huuritem huuritem)
        {
            // Als het huuritem nog niet gehuurd is, moet deze bij een persoon aan de lijst gehuurd toegevoegd worden.
            // bool isgehuurd wordt true.
            return false;
        }
    }
}
