namespace Composite.BadExample
{
	public class BadComposite
	{
		public string Name { get; set; }
		public List<BadComposite> Children { get; set; }

		public BadComposite(string name)
		{
			Name = name;
			Children = new List<BadComposite>();
		}

		public void AddChild(BadComposite child)
		{
			Children.Add(child);
		}

		public void Print()
		{
			Console.WriteLine(Name);

			foreach (var child in Children)
			{
				child.Print();
			}
		}
	}
}