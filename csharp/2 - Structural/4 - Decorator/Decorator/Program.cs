using Decorator.BadExample;
using Decorator.GoodExample;

/* --- Decorator --- */

// Main goal
// It allows to add and remove dependencies of an object dynamically, 
// and where necessary, during runtime

// Using the bad example
// Why is a bad example?
// Answer: Because the BadConcreteComponent's class sets the _component property to null which means 
// that'll throw a NullReferenceException at runtime, failing the goal of Decorator pattern
// which is to dinamically attach additional responsibility to an object without affect the others
try
{
	var badComponent = new BadConcreteComponent();
	Console.WriteLine(badComponent.Operation());

	var badDecorator = new BadConcreteDecorator(badComponent);
	Console.WriteLine(badDecorator.Operation());
}
catch (Exception ex)
{
	Console.WriteLine($"Exception Message: {ex.Message}");
}

Console.WriteLine("--------");

// Using the good example
// Why is a good example?
// Answer: Because it's literally the oposite from the bad example's answer
var goodComponent = new GoodConcreteComponent();
Console.WriteLine(goodComponent.Operation());

var goodDecorator = new GoodConcreteDecorator(goodComponent);
Console.WriteLine(goodDecorator.Operation());