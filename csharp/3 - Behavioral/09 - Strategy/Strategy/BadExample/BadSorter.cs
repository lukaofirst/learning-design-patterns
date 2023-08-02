namespace Strategy.BadExample
{
	public class BadSorter
	{
		public void Sort(int[] data, string algorithm)
		{
			if (algorithm == "BubbleSort")
				Console.WriteLine("Performing BubbleSort...");
			else if (algorithm == "QuickSort")
				Console.WriteLine("Performing QuickSort...");
		}
	}
}