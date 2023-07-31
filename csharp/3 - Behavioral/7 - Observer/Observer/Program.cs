using Observer.BadExample;
using Observer.GoodExample;

/* --- Observer --- */

// Main goal
// Provide a way to define an one-to-many dependency between objects so that when
// one object changes state, all its dependencies are notified and updated automatically

// Using the bad example
// Why is a bad example?
// Answer: Because it doesn't provide a way for an observer to unsubscribe from the subject
// leading to memory leaks, another reason is that is not following the recommended practices
// for example using the IObservable<T> and IObserver<T> interfaces provides by C#
var badSubject = new BadSubject();
var badObserver1 = new BadObserver();
var badObserver2 = new BadObserver();

badSubject.Attach(badObserver1);
badSubject.Attach(badObserver2);

badSubject.SetState(1);
badSubject.SetState(2);

badSubject.Detach(badObserver1);

badSubject.SetState(3);

Console.WriteLine("-----");

// Using the good example
// Why is a good example?
// Answer: Because it implements the IObservable<T> and IObserver<T> interfaces to define
// the subject and observer. 
// The private Unsubscriber class in the GoodSubject class is used to unsubscribe an observer
// from the subject
var goodSubject = new GoodSubject();
var goodObserver1 = new GoodObserver();
var goodObserver2 = new GoodObserver();

goodObserver1.Subscribe(goodSubject);
goodObserver2.Subscribe(goodSubject);

goodSubject.SetState(1);
goodSubject.SetState(2);

goodObserver1.Unsubscribe();

goodSubject.SetState(3);

