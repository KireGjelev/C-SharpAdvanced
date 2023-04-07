using System.ComponentModel.DataAnnotations;
using Task.Domain;
using Task.Domain.Helpers;
using Task.Domain.Models;
using Validator = Task.Domain.Helpers.Validator;

for (int i = 0; i < VehicleDb.Vehicles.Count; i++)
{
    VehicleDb.Vehicles[i].PrintVehicle();
}

Validator.Validate(VehicleDb.Vehicles[0]);
Validator.Validate(VehicleDb.Vehicles[2]);

Car car = new Car(5, "Mercedes", 2022, 2356, 80, new List<string> { "Germany" });
Bike bike = new Bike(4, "Bemix", 1994, 523, "black");

Validator.Validate(bike);
bike.PrintVehicle();
Validator.Validate(car);
car.PrintVehicle();