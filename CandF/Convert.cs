using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandF
{
    internal class Convert
    {
        public static double CtoFandFtoC(double t, string type)
        {
            if (type.Equals("F") || type.Equals("f"))
                return (t - 32) * 5 / 9;
            else if (type.Equals("C") || type.Equals("c"))
                return (t * 9) / 5 + 32;
            return 404;
        }
    }
}
