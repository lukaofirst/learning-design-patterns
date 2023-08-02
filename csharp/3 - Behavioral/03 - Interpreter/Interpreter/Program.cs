using Interpreter.BadExample;
using Interpreter.GoodExample;

/* --- Interpreter --- */

// Main goal
// Define a representation for the grammar of a given language, along with an interpreter
// that uses this representation to interpret sentences in the language

// Using the bad example
// Why is a bad example?
// Answer: Because it'll use a large switch statement to handle all possible inputs
// making it difficult to read, maintain and extend
var badInterpreter = new BadInterpreter();
Console.WriteLine(badInterpreter.Interpret("A"));
Console.WriteLine(badInterpreter.Interpret("B"));

Console.WriteLine("-----");

// Using the good example
// Why is a good example?
// Answer: Because it uses a dictionary to map inputs to their corresponding expression
// making it easier to read, maintain and extend
var goodInterpreter = new GoodInterpreter();
Console.WriteLine(goodInterpreter.Interpret("A"));
Console.WriteLine(goodInterpreter.Interpret("B"));
Console.WriteLine(goodInterpreter.Interpret("C"));
