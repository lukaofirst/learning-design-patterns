using Command.GoodExample.Interfaces;

namespace Command.GoodExample
{
	public class GoodCommand2 : ICommand
	{
		public void Execute()
		{
			Console.WriteLine($"Executing {nameof(GoodCommand2)}");
		}
	}
}