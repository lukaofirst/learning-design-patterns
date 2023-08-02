using Command.GoodExample.Interfaces;

namespace Command.GoodExample
{
	public class GoodCommand1 : ICommand
	{
		public void Execute()
		{
			Console.WriteLine($"Executing {nameof(GoodCommand1)}");
		}
	}
}