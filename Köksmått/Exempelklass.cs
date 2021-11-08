using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Köksmått
{
    class Exempelklass
    {

        public static Dictionary<string, double> measureList = new Dictionary<string, double>() { { "liter", 10 }, { "deciliter", 1 }, { "ukgallon", 45 }, { "ukpint", 5.7 } };



        public static double litertogallon(double amount)
        {
            double sum = measureList["liter"] * amount / measureList["ukgallon"];
            
            return sum;
        }

        public static double litertopint(double amount)
        {
            double sum = measureList["liter"] * amount / measureList["ukpint"];
            return sum;
        }
    }
}
