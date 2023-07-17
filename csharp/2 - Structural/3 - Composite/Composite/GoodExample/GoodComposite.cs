using Composite.Interfaces.GoodExample;

namespace Composite.GoodExample
{
	public class GoodComposite : IComponent
	{
		public string Name { get; set; }
		private readonly List<IComponent> _children = new();

		public GoodComposite(string name)
		{
			Name = name;
		}

		public void AddChildren(IComponent child)
		{
			_children.Add(child);
		}

		public void Print()
		{
			Console.WriteLine(Name);

			foreach (var child in _children)
			{
				child.Print();
			}
		}
	}
}