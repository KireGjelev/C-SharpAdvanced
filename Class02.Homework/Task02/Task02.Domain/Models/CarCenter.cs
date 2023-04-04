using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task02.Domain.Interfaces;

namespace Task02.Domain.Models
{
    public class CarCenter : ICarWash, IGasPump, IRepairService
    {

        public string Label { get; set; }
        public string HoursOfOperation { get; set; }
        public int RentableCars { get; set; }
        public CarCenter()
        {

        }
        public CarCenter(string label, string hoursofoperating, int rentablecars)
        {
            if (string.IsNullOrEmpty(label))
            {
                Console.WriteLine("Invalid input for service auto house name");
            }
            if (string.IsNullOrEmpty(hoursofoperating))
            {
                Console.WriteLine("Invalid input for hours of operation");
            }
            if (rentablecars > 0)
            {
                Console.WriteLine($"In our Expert Auto Services we have {RentableCars} vehicles for rent.");
            }
            else
            {
                Console.WriteLine("Invalid input for renal vehicles");
            }

            Label = label;
            HoursOfOperation = hoursofoperating;
            RentableCars = rentablecars;
        }

        public void CheckVehicle()
        {
            Console.WriteLine("Checked your car for issues. It's ok.");
        }

        public void FixVehicle()
        {
            Console.WriteLine("Your car it's ok!!");
        }

        public void PumpGas()
        {
            Console.WriteLine("WARNING - Your car is empty, refuel gas!");
        }

        public void WashCar(Car car)
        {
            Console.WriteLine("The car is clear!");
        }

        public void WashTrailer(Truck truck)
        {
            Console.WriteLine("The truck is clear!");
        }
    }
}
