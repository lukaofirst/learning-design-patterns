using TemplateMethod.BadExample;
using TemplateMethod.GoodExample;

/* --- Template Method --- */

// Main goal
// Define a skeleton for perfoming any sort of algorithm or operation,
// and it allows the subclasses to re-define part of the logic

// Using the bad example
// Why is a bad example?
// Answer: Because all the operations in the BadTemplateMethod class are abstract
// and must be implemented by the subclass
var badConcreteClass = new BadConcreteClass();
badConcreteClass.TemplateMethod();

Console.WriteLine("-----");

// Using the good example
// Why is a good example?
// Answer: Because it provides default implementations for all the operations using
// the virtual keyword
var goodConcreteClass = new GoodConcreteClass();
goodConcreteClass.TemplateMethod();