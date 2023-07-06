using Builder.BadExample;
using Builder.GoodExample;

/* --- Builder --- */

// Main goal
// Separate the construction of a complex object from it's representation
// so that the same construction process can create different representations

// Using the bad example
// Why is a bad example?
// Answer: Because it doesn't provide any validation or constraints
// on the Car's properties
var badCarBuilder = new BadCarBuilder();
var car1 = badCarBuilder
	.SetName("VW Polo")
	.SetColor("Silver")
	.SetHorsePower(90)
	.Build();

Console.WriteLine(car1);

// Using the good example 
// Why is a good example?
// Answer: Because it provides validations and constraints on the Car's
// properties, throwing exceptions if the arguments are invalid
// being "careful on how the object is created"
var goodCarBuilder = new GoodCarBuilder();
var car2 = goodCarBuilder
	.SetName("Mercedes A250")
	.SetColor("White")
	.SetHorsePower(221)
	.Build();

Console.WriteLine(car2);