using System;

namespace Köksmått
{
    class Program
    {
        static void Main(string[] args)
        {

            //Measuerments.measureList.Add("liter", 1000);
            //Measuerments.measureList.Add("deciliter", 100);

            Measurements.InitializeMeasurements();
            Startmenu.StartProgram();


        }
    }
}
