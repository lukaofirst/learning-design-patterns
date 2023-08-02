using Memento.BadExample;
using Memento.GoodExample;

/* --- Memento --- */

// Main goal
// Provide a mechanism for restoring an object's state to a previous state 
// without violating its encapsulation

// Using the bad example
// Why is a bad example?
// Answer: Because it violates the encapsulation of the BadOriginator object
// the State property on BadOriginator and BadMemento is public acessible 
// which means that any class outside can modify his behavior
var badOriginator = new BadOriginator();
var badCaretaker = new BadCaretaker();

badOriginator.SetState("BadState1");
badOriginator.State = "whatever"; // setting State property as public can lead to unexpected behavior
badCaretaker.Memento = badOriginator.CreateMemento();

badOriginator.SetState("BadState2");
badOriginator.RestoreFromMemento(badCaretaker.Memento);

Console.WriteLine("-----");

// Using the good example
// Why is a good example?
// Answer: Because it keeps the encapsulation of the GoodOriginator object
// you can't access from outside the State from both GoodOriginator and GoodMemento classes
var goodOriginator = new GoodOriginator();
var goodCaretaker = new GoodCaretaker();

goodOriginator.SetState("GoodState1");
goodCaretaker.Memento = goodOriginator.CreateMemento();

goodOriginator.SetState("GoodState2");
goodOriginator.RestoreFromMemento(goodCaretaker.Memento);