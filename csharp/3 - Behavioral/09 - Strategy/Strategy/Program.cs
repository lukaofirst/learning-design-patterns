using Strategy.BadExample;
using Strategy.GoodExample;

/* --- Strategy  --- */

// Main goal
// Define a family of algorithms, encapsulate each one, and make them interchangeable

var numbers = new int[] { 1000, 100, 10, 1 };

// Using the bad example
// Why is a bad example?
// Answer: Because it violates the Open-Closed Principle, if we want to add a new sorting
// algorithm, we have to modify the Sort method in the BadSorter class
var badSorter = new BadSorter();
badSorter.Sort(numbers, "BubbleSort");

Console.WriteLine("-----");

// Using the good example
// Why is a good example?
// Answer: Because it follows the Open-Closed Principle, if we want to add a new sorting
// algorithm, we can create a new class that implements the ISortStrategy interface
var bubbleSortStrategy = new BubbleSortStrategy();
var goodSorter = new GoodSorter(bubbleSortStrategy);
goodSorter.Sort(numbers);
