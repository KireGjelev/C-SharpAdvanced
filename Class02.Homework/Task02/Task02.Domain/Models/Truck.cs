using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02.Domain.Models
{
    public class Truck : Vehicle
    {
        public int TowingCapacity { get; set; }
        public Truck()
        {

        }

        public Truck(string name, string color, int vin, int towingCapacity) : base(name, color, vin)
        {
            if (towingCapacity < 0)
            {
                Console.WriteLine("Towing capacity must be a positive integer.");
            }
            if (towingCapacity > 13500)
            {
                Console.WriteLine("Towing capacity exceeds maximum limit of 13500 kg.");
            }
            else
            {
                Console.WriteLine("Towing capacity is valid.");
            }

            TowingCapacity = towingCapacity;
        }



        public override void Drive()
        {
            Console.WriteLine($"The oldest truck in our Auto Service is the {Color} {Name}.");
        }
    }
}
