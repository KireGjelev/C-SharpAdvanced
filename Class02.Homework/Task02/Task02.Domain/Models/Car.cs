using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02.Domain.Models
{
    public class Car : Vehicle
    {
        public int NumberOfDoors { get; set; }
        public Car()
        {

        }
        public Car(string name, string color, long vin, int numberofdoors) : base(name, color, vin)
        {
            NumberOfDoors = numberofdoors;
        }
        public override void Drive()
        {
            Console.WriteLine($"I am driving newest model of {Name}");
        }


    }
}
