using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KayuCarRental
{
    class Compact : Car
    {
        string type = "Compact";
        const double dayPrice = 19.95;
        
        public Compact(int day)
        {
            total = day * dayPrice;
        }
        public override string ToString() //allows this string with variables to pass during an object call
        {
            return type;
        }
    }
}
