namespace Command.BadExample
{
	public class BadCommand
	{
		public void Execute(string command)
		{
			switch (command)
			{
				case "Command1":
					Console.WriteLine("Executing Command1");
					break;
				case "Command2":
					Console.WriteLine("Executing Command2");
					break;
				default:
					Console.WriteLine("Unknown command");
					break;
			}
		}
	}
}