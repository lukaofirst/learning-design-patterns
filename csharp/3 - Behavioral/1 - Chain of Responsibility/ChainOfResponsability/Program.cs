using ChainOfResponsability.BadExample;
using ChainOfResponsability.GoodExample;

/* --- Chain of Responsibility --- */

// Main goal
// It's to decouple the client (request) from the entity 
// that will handle the request in a given case

// Using the bad example
// Why is a bad example?
// Answer: Because it violates the Single Responsibility Principle, 
// like so BadHandler has more than one reason to change
var handler = new BadHandler();
handler.HandlerRequest("TypeA");
handler.HandlerRequest("TypeB");
handler.HandlerRequest("TypeC");

Console.WriteLine("-----");

// Using the good example
// Why is a good example?
// Answer: Because it follows the Single Responsibility Principle, as each class has only reason to change
// and adding or removing a request type only requires creating or deleting a concrete handler class,
// following the Open-Closed Principle
var handlerTypeA = new TypeAHandler();
var handlerTypeB = new TypeBHandler();

handlerTypeA.SetSuccessor(handlerTypeB);

handlerTypeA.HandlerRequest("TypeA");
handlerTypeA.HandlerRequest("TypeB");
handlerTypeA.HandlerRequest("TypeC");