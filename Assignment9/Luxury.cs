using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KayuCarRental
{
    class Luxury : Car
    {
        string type = "Luxury";
        const double dayPrice = 39;
        public Luxury(int day)
        {
            total = day * dayPrice;
        }

        public override string ToString() 
        {
            return type;
        }
    }
}
