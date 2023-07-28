
using Mediator.BadExample;
using Mediator.GoodExample;

/* --- Mediator --- */

// Main goal
// Reduce the complexity and dependencies between tightly coupled objects
// communicating directly with one another

// Using the bad example
// Why is a bad example?
// Answer: Because it doesn't provide a way to filter messages or specify which users should receive them
var badMediator = new BadMediator();

var bob = new BadUser("Bob", badMediator);
var mark = new BadUser("Mark", badMediator);
var george = new BadUser("George", badMediator);

badMediator.Register(bob);
badMediator.Register(mark);
badMediator.Register(george);

bob.Send("Hello from Bob");
mark.Send("Hello from Mark");
george.Send("Hello from George");

Console.WriteLine("-----");

// Using the good example
// Why is a good example?
// Answer: Because it promotes loose coupling and reduces dependencies between objects
// The GoodMediator handles to forward the messages to the appropriate users
var goodMediator = new GoodMediator();

var arthur = new GoodUser("Arthur", goodMediator);
var lorem = new GoodUser("Lorem", goodMediator);
var john = new GoodUser("John", goodMediator);

goodMediator.Register(arthur);
goodMediator.Register(lorem);
goodMediator.Register(john);

arthur.Send("Hello from Arthur");
lorem.Send("Hello from Lorem");
john.Send("Hello from John");