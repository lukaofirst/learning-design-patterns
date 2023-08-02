namespace Iterator.GoodExample
{
	public class GoodCollection
	{
		private readonly List<int> _items;

		public GoodCollection(List<int> items)
		{
			_items = items;
		}

		public IEnumerable<int> GetEnumerable()
		{
			for (int i = 0; i < _items.Count; i++)
			{
				yield return _items[i];
			}
		}
	}
}