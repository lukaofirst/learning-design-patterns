using Prototype.BadExample;
using Prototype.GoodExample;

/* --- Prototype --- */

// Main Goal
// It's to allow creating new objects by copying existing ones

// Using the bad example
// Why is a bad example?
// Answer: Because the BadEmployeeImpl.Clone() returning just the original object as reference,
// changing the employee2's properties changes the employee1's properties as well
// without the .Clone() method, is exactly the same result as [employee2 = employee1]
var employee1 = new BadEmployeeImpl
{
	Name = "Lorem",
	Department = "IT"
};
var employee2 = employee1.Clone();
employee2.Department = "HR";

Console.WriteLine($"Employee 1 - Name: {employee1.Name}, Department: {employee1.Department}");
Console.WriteLine($"Employee 2 - Name: {employee2.Name}, Department: {employee2.Department}");

Console.WriteLine("-----");

// Using the good example
// Why is a good example?
// Answer: Because it really creates a new employee object by copying an existing object without 
// mutate the original object
// without the .Clone() method, you would have to create a new instance mapping each property
var employee3 = new GoodEmployeeImpl
{
	Name = "Ipsum",
	Department = "Business"
};
var employee4 = employee3.Clone();
employee4.Department = "Marketing";

Console.WriteLine($"Employee 3 - Name: {employee3.Name}, Department: {employee3.Department}");
Console.WriteLine($"Employee 4 - Name: {employee4.Name}, Department: {employee4.Department}");