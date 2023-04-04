using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02.Domain.Models
{
    public abstract class Vehicle
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public long VIN { get; set; }

        public Vehicle()
        {

        }
        public Vehicle(string name, string color, long vin)
        {
            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Invalid input for name");
            }

            Name = name;

            if (string.IsNullOrEmpty(color))
            {
                Console.WriteLine("Invalid input for color");
            }
            Color = color;

            if (vin > 0)
            {
                VIN = vin;
            }
            else
            {
                Console.WriteLine("Invalid input for vehicle identification number");
            }
        }

        public abstract void Drive();
    }
}
