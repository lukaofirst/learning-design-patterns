using State.BadExample;
using State.GoodExample;

/* --- State --- */

// Main goal
// Allow an object to change its behavior when its internal state changes

// Using the bad example
// Why is a bad example?
// Answer: Because the BadPackage class is responsible for both managing its state and printing its devivery status, 
// violating both Single Responsiblity Principle (SRP) and Open-Closed Principle (OCP)
var badPackage = new BadPackage
{
	State = BadPackage.PackageStateEnum.Ordered
};

badPackage.PrintDeliveryStatus();
badPackage.State = BadPackage.PackageStateEnum.Delivered;
badPackage.PrintDeliveryStatus();
badPackage.State = BadPackage.PackageStateEnum.Received;
badPackage.PrintDeliveryStatus();

Console.WriteLine("-----");

// Using the good example
// Why is a good example?
// Answer: Because each state is encapsulated in its own class, implemented by the IPackageState interface
// and the GoodPackage delegates the responsibility of printing the delivery status to its current state
var goodPackage = new GoodPackage
{
	State = new OrderedState()
};

goodPackage.PrintDeliveryStatus();
goodPackage.State = new DeliveredState();
goodPackage.PrintDeliveryStatus();
goodPackage.State = new ReceivedState();
goodPackage.PrintDeliveryStatus();
