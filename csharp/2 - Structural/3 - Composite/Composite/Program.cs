using Composite.BadExample;
using Composite.GoodExample;
using Composite.RealisticExample;

/* --- Composite --- */

// Main goal

// Using the bad example
// Why is a bad example?
// Answer: Because it doesn't have a common interface or base class for individual or composite objects
// which means that the client code has to check the type of object before calling its methods
var badRoot = new BadComposite("Root");
var badChild1 = new BadComposite("Child 1");
var badChild2 = new BadComposite("Child 2");

badRoot.AddChild(badChild1);
badRoot.AddChild(badChild2);
badRoot.Print();

Console.WriteLine("------------------");

// Using the good example
// Why is a good example?
// Answer: Because it has a common interface (Component) for individual objects and (Leaf) the composite objects
// which means that the client code can treat them in a uniform way
var goodRoot = new GoodComposite("Root");
var goodChild1 = new GoodComposite("Child 1");
var goodChild2 = new GoodComposite("Child 2");

goodRoot.AddChildren(goodChild1);
goodRoot.AddChildren(goodChild2);
goodRoot.Print();

Console.WriteLine("------------------");

var ceo = new Manager("CEO");
var cto = new Manager("CTO");
var devManager = new Manager("Dev Manager");
var qaManager = new Manager("QA Manager");
var developer1 = new Employee("Developer 1");
var developer2 = new Employee("Developer 2");
var tester1 = new Employee("Tester 1");
var tester2 = new Employee("Tester 2");

ceo.AddSubordinate(cto);
cto.AddSubordinate(devManager);
cto.AddSubordinate(qaManager);
devManager.AddSubordinate(developer1);
devManager.AddSubordinate(developer2);
qaManager.AddSubordinate(tester1);
qaManager.AddSubordinate(tester2);

ceo.Display(0);