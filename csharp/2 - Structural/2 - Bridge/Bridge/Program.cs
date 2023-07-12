using Bridge.BadExample;
using Bridge.GoodExample;
using Bridge.RealisticExample;
using Bridge.RealisticExample.Interfaces;

/* --- Bridge --- */

// Main goal
// It's to decouple an abstraction from its implementation so
// that the two can vary independently

// Note
// Take abstraction as the Implementor
// And implementations as the Concrete Implementors

// Using the bad example
// Why is a bad example?
// Answer: Because the abstraction (BadRemoteControl) is tighly coupled 
// to his implementations (BadRadioRemoteControl) and (BadTelevisionRemoteControl)
// making it difficult to change
BadRemoteControl badRemote = new BadRadioRemoteControl();

badRemote.TurnOn();
badRemote.TurnOff();

badRemote = new BadTelevisionRemoteControl();

badRemote.TurnOn();
badRemote.TurnOff();

Console.WriteLine("-----");

// Using the good example
// Why is a good example?
// Answer: Because it decouples the abstraction from its implementation,
// allowing for greater flexibility and easier maintenance of code
IDevice radio = new Radio();
RemoteControl remote = new BasicRemoteControl(radio);

remote.On();
remote.Off();

IDevice tv = new Television();
remote = new BasicRemoteControl(tv);

remote.On();
remote.Off();

Console.WriteLine("-----");

// Using the realistic example
IMessageSender email = new EmailSender();
IMessage message = new TextMessage(email, "Hello", "Lorem Ipsum from email");

message.Send();

IMessageSender sms = new SmsSender();
message = new TextMessage(sms, "Hello", "Lorem Ipsum from sms");

message.Send();