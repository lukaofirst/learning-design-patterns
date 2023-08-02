namespace Iterator.BadExample
{
	public class BadCollection
	{
		private readonly List<int> _items;

		public BadCollection(List<int> items)
		{
			_items = items;
		}

		public List<int> GetItems()
		{
			return _items;
		}
	}
}