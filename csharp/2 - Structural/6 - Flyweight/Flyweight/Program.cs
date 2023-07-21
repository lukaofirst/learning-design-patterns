using Flyweight.BadExample;
using Flyweight.GoodExample;

/* --- Flyweight --- */

// Main goal
// Reduce memory usage by sharing as much data as possible between similar objects

// Using a bad example
// Why is a bad example?
// Answer: Because it doesn't handle recycling flyweight objects
// This means that once flyweight object is created and added to the dictionary
// in the BadFlyweightFactory class, it will remain there even if it's no longer needed
var badFlyweightFactory = new BadFlyweightFactory();
var flyweight1 = badFlyweightFactory.GetFlyweight("lorem");
flyweight1.Operation("ipsum");

// Using a good example
// Why is a good example?
// Answer: Because it has a method called .Recycle() 
// that handles the recycling flyweight objects
var goodFlyweightFactory = new GoodFlyweightFactory();
goodFlyweightFactory.Recycle(flyweight1);
flyweight1.Operation("world");