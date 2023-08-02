using Iterator.BadExample;
using Iterator.GoodExample;

/* --- Iterator --- */

// Main goal
// Provide a standard way to traverse through the elements of a collection 
// without exposing its internal structure

var items = new List<int> { 1, 10, 100, 1000, 10000 };

// Using the bad example
// Why is a bad example?
// Answer: Because it exposes the internal representation of the collection
var badCollection = new BadCollection(items);
badCollection.GetItems().ForEach(x => Console.WriteLine(x));

Console.WriteLine("-----");

// Using the good example
// Why is a good example?
// Answer: Because it provides a standard way to access the elements of 
// the collection sequentially without exposing its internal representation
var goodCollection = new GoodCollection(items);
goodCollection.GetEnumerable().ToList().ForEach(x => Console.WriteLine(x));