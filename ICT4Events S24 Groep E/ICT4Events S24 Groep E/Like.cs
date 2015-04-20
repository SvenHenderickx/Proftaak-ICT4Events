using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICT4Events_S24_Groep_E
{
    public class Like
    {
        //Field
        private Persoon liker;

        //Property
        public Persoon Liker
        {
            get { return liker; }
        }

        //Constructor
        public Like(Persoon liker)
        {
            this.liker = liker;
        }
    }
}
