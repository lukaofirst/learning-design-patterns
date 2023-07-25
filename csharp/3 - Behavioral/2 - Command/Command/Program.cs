using Command.BadExample;
using Command.GoodExample;

/* --- Command --- */

// Main goal
// Encapsulate all the data required for performing a given action (command)
// in an object

// Using the bad example
// Why is a bad example?
// Answer: Because it uses a switch statement to determine which command to execute
var badCommand = new BadCommand();
badCommand.Execute("Command1");
badCommand.Execute("Command2");

Console.WriteLine("-----");

// Using the good example
// Why is a good example?
// Answer: Because if we need to create more commands, you just need to create new 
// classes that implements the ICommand interface without modifying any existing code
var goodCommand1 = new GoodCommand1();
goodCommand1.Execute();

var goodCommand2 = new GoodCommand2();
goodCommand2.Execute();