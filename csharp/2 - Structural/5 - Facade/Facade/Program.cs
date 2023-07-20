using Facade.BadExample;
using Facade.GoodExample;
using Facade.RealisticExample;
using Facade.RealisticExample.Entities;

/* --- Facade --- */

// Main goal
// Hide the complexity of the subsystem and make it easier to use

// Using the bad example
// Why is a bad example?
// Answer: Because it doesn't povide any abstraction or simplification of the underlying subsystems
// It just delegates its methods to the corresponding methods of the subsystems
var badFacade = new BadFacade();
badFacade.Operation1();
badFacade.Operation2();

Console.WriteLine("-----");

// Using the good example
// Why is a good example?
// Answer: Because it provides a simplified interface to a complex system, 
// abstracting away its complexity and making it easier to use
var goodFacade = new GoodFacade();
goodFacade.StartEngine();
goodFacade.StopEngine();

Console.WriteLine("-----");

// Using the realistic example
var orderFacade = new OrderFacade();

var customer = new Customer("Lorem Ipsum", "St. Street 12");
var products = new List<Product>()
{
	new Product("Product 1", 10.25),
	new Product("Product 2", 50.33),
};
var order = new Order(customer, products, products.Sum(x => x.Price));

orderFacade.PlaceOrder(order);