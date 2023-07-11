using Adapter.BadExample;
using Adapter.Common;
using Adapter.GoodExample;

/* --- Adapter --- */

// Main Goal
// Convert an existing interface into another that the client expects

// Using the bad example
// Why is a bad example?
// Answer: Because it uses inheritance to implement the Adapter pattern
// This approach can lead to unexpected side-effects when you need to change existing code
var badAdapter = new BadAdapter();
badAdapter.SpecificRequest();

Console.WriteLine("-----");

// Using the good example
// Why is a good example?
// Answer: Because it uses composition to implement the Adapter pattern
// This approach avoid unexpected side-effects when you need to change existing code
var adaptee = new Adaptee();
var goodAdapter = new GoodAdapter(adaptee);
goodAdapter.Request();