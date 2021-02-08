using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KayuCarRental
{
    class Standard : Car
    {
        string type = "Standard";
        const double dayPrice = 24.95;
        public Standard(int day)
        {
            total = day * dayPrice;
        }

        public override string ToString() //allows this string with variables to pass during an object call
        {
            return type;
        }
    }
}
