using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaalit_1
{
    class VertailuAanimaaranMukaan : IComparer<Ehdokas>
    {
        public int Compare(Ehdokas x, Ehdokas y)

        {
            return x.Aanimaara-y.Aanimaara;
        }

        
        public static IComparer<Ehdokas> AanienMukaan()
        {
            return new VertailuAanimaaranMukaan();

        }
    }
}
