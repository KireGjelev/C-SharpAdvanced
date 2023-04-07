using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.Domain.Models
{
    public class Bike : Vehicle
    {
        public string Color { get; set; }

        public Bike()
        {

        }

        public Bike(int id, string type, int yearOfProduction, int batchNumber, string color) : base(id, type, yearOfProduction, batchNumber)
        {
            if (string.IsNullOrEmpty(color))
            {
                Console.WriteLine("Invalid input");
            }
            Color = color;
        }

        public override void PrintVehicle()
        {
            Console.WriteLine($"Bike: Year of Production: {YearOfProduction}, Color: {Color}");
        }
    }
}