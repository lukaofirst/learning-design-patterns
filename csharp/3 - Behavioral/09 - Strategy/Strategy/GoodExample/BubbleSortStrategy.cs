using Strategy.GoodExample.Interfaces;

namespace Strategy.GoodExample
{
	public class BubbleSortStrategy : ISortStrategy
	{
		public void Sort(int[] data)
		{
			Console.WriteLine("Performing BubbleSort...");
		}
	}
}