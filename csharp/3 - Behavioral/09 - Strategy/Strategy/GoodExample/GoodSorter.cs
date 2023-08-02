using Strategy.GoodExample.Interfaces;

namespace Strategy.GoodExample
{
	public class GoodSorter
	{
		private readonly ISortStrategy _sortStrategy;

		public GoodSorter(ISortStrategy sortStrategy)
		{
			_sortStrategy = sortStrategy;
		}

		public void Sort(int[] data)
		{
			_sortStrategy.Sort(data);
		}
	}
}