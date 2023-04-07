using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.Domain.Models
{
    public class Car : Vehicle
    {
        public int FuelTank { get; set; }
        public List<string> Countries { get; set; }

        public Car()
        {
            Countries = new List<string>();
        }

        public Car(int id, string type, int yearOfProduction, int batchNumber, int fuelTank, List<string> countries) : base(id, type, yearOfProduction, batchNumber)
        {
            FuelTank = fuelTank;
            Countries = countries;
        }


        public override void PrintVehicle()
        {
            Console.WriteLine($"Type of car: {Type}, Countries Produced: {string.Join(",", Countries)}");
        }
    }
}
