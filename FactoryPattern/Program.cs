using FactoryPattern;

Console.WriteLine("How many tires are on the vehicle?");
int numWheels = int.Parse(Console.ReadLine());

var myVehicle = VehicleFactory.GetVehicle(numWheels);
myVehicle.Drive();