using Proxy.BadExample;
using Proxy.GoodExample;

/* --- Proxy --- */

// Main goal
// Create an intermediary that acts as an interface to another resource,
// while also hiding the underlying complexity of the component

// Using the bad example
// Why is a bad example?
// Answer: Because it tightly couples the BadProxy to the RealService
// Which means if we change RealService, we'll have to change the BadProxy as well
var realService = new RealService();

var badProxy = new BadProxy(realService);
badProxy.Request();

Console.WriteLine("-----");

// Using the good example
// Why is a good example?
// Answer: Because it decouples the GoodProxy from the underlying service using an interface IService
var goodProxy = new GoodProxy(realService);
goodProxy.Request();