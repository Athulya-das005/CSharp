using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revision_WEEK_1
{
    public class Car
    {
        //properties :
        public string name;
        public string model;

        public int year;


        //constructor:

        public Car(string CarName, string CarModel, int CarYear)
        {
            name = CarName;
            model = CarModel;
            year = CarYear;
        }

        //methods:

        public void StartEngine()
        {
            Console.WriteLine("THE ENGINE IS NOW RUNNING ");
        }

        public void StopEngine()
        {
            Console.WriteLine("THE ENGINE IS NOW OFF");
        }

        public void DisplayCarInfo()
        {
            Console.WriteLine($"car info: {name} {model} {year}");
        }

        
    }
}
