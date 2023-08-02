using Visitor.BadExample;
using Visitor.BadExample.Interfaces;
using Visitor.GoodExample;
using Visitor.GoodExample.Interfaces;

/* --- Visitor --- */

// Main goal
// Allows to add new operations to an object structure without modifying
// the classes of the objects

// Using the bad example
// Why is a bad example?
// Answer: Because it adds unnecessary complexity to the code
// The object structure is simple and doesn't require the use of the Visitor patterns
var badElements = new List<IBadElement>
{
	new BadConcreteElementA(),
	new BadConcreteElementB(),
};

var badVisitor1 = new BadConcreteVisitor1();
var badVisitor2 = new BadConcreteVisitor2();

foreach (var badElement in badElements)
{
	badElement.Accept(badVisitor1);
	badElement.Accept(badVisitor2);
}

Console.WriteLine("-----");

// Using the good example
// Why is a good example?
// Answer: Because here you have a complex object structure and you need to perform 
// operations on the objects without changing their classes
var goodElements = new List<IGoodVisitable>
{
	new GoodElementA(1),
	new GoodElementB("2"),
	new GoodElementA(3),
	new GoodElementB("4"),
};

var visitor = new GoodSumVisitor();

foreach (var goodElement in goodElements)
{
	goodElement.Accept(visitor);
}

Console.WriteLine($"Sum: {visitor.Sum}");