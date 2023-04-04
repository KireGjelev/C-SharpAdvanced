using Task02.Domain.Models;

Car car = new Car("porsche", "black", 12345678901234567, 2);
car.Drive();

Truck truck = new Truck("ford", "grey", 12345678, 10000);
truck.Drive();

CarCenter carCenter = new CarCenter("Expert Auto Services", "8", 10);
carCenter.WashCar(car);
carCenter.WashTrailer(truck);
carCenter.PumpGas();
carCenter.CheckVehicle();
carCenter.FixVehicle();

RepairService repairService = new RepairService();
repairService.CheckVehicle();
repairService.FixVehicle();

CarWash carWash = new CarWash();
carWash.WashCar(car);
carWash.WashTrailer(truck);

GasPump gasPump = new GasPump();
gasPump.PumpGas();