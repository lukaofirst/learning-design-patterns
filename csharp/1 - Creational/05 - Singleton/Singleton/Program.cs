using Singleton.BadExample;
using Singleton.GoodExample;

/* --- Singleton --- */

// Main Goal
// Restrict the instantiation of a class 
// and ensure that only one instance of the class exist

// Using the bad example
// Why is a bad example?
// Answer: Because it's not a thread-safe, if 2 threads calls the Instance field
// at the same type, it possibly will create 2 instances
var badSingleton = BadSingleton.Instance;

// Using the good example
// Why is a good example?
// Answer: It's a thread safe because the field Instance field is initialized
// when the class is loaded, which happens before any threads can access it
var goodSingleton = GoodSingleton.Instance;
var goodSingleton2 = GoodSingleton.Instance;

Console.WriteLine(ReferenceEquals(badSingleton, goodSingleton));
Console.WriteLine(ReferenceEquals(goodSingleton, goodSingleton2));