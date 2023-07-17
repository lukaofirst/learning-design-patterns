namespace Composite.RealisticExample
{
	public class Manager : IEmployee
	{
		public string Name { get; set; }
		private readonly List<IEmployee> _subordinates = new();

		public Manager(string name)
		{
			Name = name;
		}

		public void AddSubordinate(IEmployee employee)
		{
			_subordinates.Add(employee);
		}

		public void Display(int indent)
		{
			Console.WriteLine(new string('-', indent) + Name);

			foreach (var subordinate in _subordinates)
			{
				subordinate.Display(indent + 2);
			}
		}
	}
}