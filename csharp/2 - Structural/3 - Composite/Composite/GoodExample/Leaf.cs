using Composite.Interfaces.GoodExample;

namespace Composite.GoodExample
{
	public class Leaf : IComponent
	{
		public string Name { get; set; }

		public Leaf(string name)
		{
			Name = name;
		}

		public void Print()
		{
			Console.WriteLine(Name);
		}
	}
}