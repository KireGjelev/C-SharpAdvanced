using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.Domain.Models;

namespace Task.Domain
{
    public static class VehicleDb
    {
        public static List<Vehicle> Vehicles;

        static VehicleDb()
        {
            Vehicles = new List<Vehicle>()
            {
                new Car() { Id = 1, Type = "Tesla", YearOfProduction = 2022, BatchNumber = 1001, FuelTank = 50, Countries = new List<string> { "USA", "China", "Germany" }},
                new Bike() { Id = 2, Type = "Sport", YearOfProduction = 2020, BatchNumber = 2001, Color = "White" },
                new Vehicle() { Id = 3, Type = "Bus", YearOfProduction = 2020, BatchNumber = 3001 }
            };
        }
    };
};