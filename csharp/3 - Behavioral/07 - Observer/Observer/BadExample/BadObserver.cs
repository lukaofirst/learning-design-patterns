namespace Observer.BadExample
{
	public class BadObserver
	{
		public void Update(int state)
		{
			Console.WriteLine($"State changed to: {state}");
		}
	}
}