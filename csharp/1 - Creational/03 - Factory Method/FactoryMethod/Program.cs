using FactoryMethod.BadExample;
using FactoryMethod.Common;
using FactoryMethod.Common.Interfaces;
using FactoryMethod.GoodExample;
using FactoryMethod.RealisticExample;

/* --- Factory Method --- */

// Main Goal
// Define an interface for creating an object, but let subclasses decide which class to instantiate

// Using the bad example
// Why is a bad example?
// Answer: Because it violates the Open-Closed Principle. 
// If we want to add a new type of car, we have to modify the BadCarFactory.CreateCar() method
var badCarFactory = new BadCarFactory();
var badRegularCar = badCarFactory.CreateCar("Regular");
Console.WriteLine(badRegularCar.GetCarName());

var badSportsCar = badCarFactory.CreateCar("Sports");
Console.WriteLine(badSportsCar.GetCarName());

Console.WriteLine("-----");

// Using the good example
// Why is a good example?
// Answer: Because it follows the Open-Closed Principle.
// If we want to add a new type of car, we can create a class that implements the IGoodCarFactory interface,
// without modifying the existing code
var regularCarFactory = new RegularCarFactory();
var regularCar = regularCarFactory.CreateCar();
Console.WriteLine(regularCar.GetCarName());

var sportsCarFactory = new SportsCarFactory();
var sportsCar = sportsCarFactory.CreateCar();
Console.WriteLine(sportsCar.GetCarName());

Console.WriteLine("-----");

// Using the realistic example
var realisticCarFactory = new RealisticCarFactory()
	.Register("Regular", () => new RegularCar())
	.Register("Sports", () => new SportsCar());

var realisticRegularCar = realisticCarFactory.Create("Regular");
Console.WriteLine(realisticRegularCar.GetCarName());

var realisticSportsCar = realisticCarFactory.Create("Sports");
Console.WriteLine(realisticSportsCar.GetCarName());
