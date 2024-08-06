using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Designpatters
{
    class Program
    {
        static void Main(string[] args)
        {
            Taxcalculator2019 taxcalculator2019 = new Taxcalculator2019();
           float t= taxcalculator2019.TaxCalculator();
        }
    }
}
