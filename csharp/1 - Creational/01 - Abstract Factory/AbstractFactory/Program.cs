using AbstractFactory.BadExample;
using AbstractFactory.Common.Enums;
using AbstractFactory.GoodExample;

/* --- Abstract Factory --- */

// Main goal
// Provide an interface for creating families of related or dependent objects 
// without specifying their concrete classes

// Using the bad example
// Why is a bad example?
// Answer: Because the BadVehicleFactory class is not an abstraction
// and it uses a switch statement to create the appropriate car
// This means that if we want to add a new car type, 
// we must modify the BadVehicleFactory class, adding a new if statement
var badSportsCar = BadVehicleFactory.CreateCar(VehicleFactoryType.Sports);
Console.WriteLine(badSportsCar.GetCarName());
var badSportsBike = BadVehicleFactory.CreateBike(VehicleFactoryType.Sports);
Console.WriteLine(badSportsBike.GetBikeName());

var badRegularCar = BadVehicleFactory.CreateCar(VehicleFactoryType.Regular);
Console.WriteLine(badRegularCar.GetCarName());
var badRegularBike = BadVehicleFactory.CreateBike(VehicleFactoryType.Regular);
Console.WriteLine(badRegularBike.GetBikeName());

Console.WriteLine("-------");

// Using the good example
// Why is a good example?
// Answer: Because we use the factories instances to create instances
// of the SportsCar and RegularCar calling the CreateCar() method
var sportsFactory = new SportsFactory();
var goodSportsCar = sportsFactory.CreateCar();
Console.WriteLine(goodSportsCar.GetCarName());
var goodSportsBike = sportsFactory.CreateBike();
Console.WriteLine(goodSportsBike.GetBikeName());

var regularFactory = new RegularFactory();
var goodRegularCar = regularFactory.CreateCar();
Console.WriteLine(goodRegularCar.GetCarName());
var goodRegularBike = regularFactory.CreateBike();
Console.WriteLine(goodRegularBike.GetBikeName());