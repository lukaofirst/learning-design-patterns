using Strategy.GoodExample.Interfaces;

namespace Strategy.GoodExample
{
	public class QuickSortStrategy : ISortStrategy
	{
		public void Sort(int[] data)
		{
			Console.WriteLine("Performing QuickSort...");
		}
	}
}