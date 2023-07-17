namespace Composite.RealisticExample
{
	public class Employee : IEmployee
	{
		public string Name { get; set; }

		public Employee(string name)
		{
			Name = name;
		}

		public void Display(int indent)
		{
			Console.WriteLine(new string('-', indent) + Name);
		}
	}
}