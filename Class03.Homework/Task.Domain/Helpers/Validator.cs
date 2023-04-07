using Task.Domain.Models;

namespace Task.Domain.Helpers
{
    public static class Validator
    {

        public static void Validate(Vehicle vehicle)
        {
            if (vehicle.Id <= 0 || string.IsNullOrEmpty(vehicle.Type) || vehicle.YearOfProduction <= 0)
            {
                Console.WriteLine("Vehicle validation failed");
            }
        }
    }
}