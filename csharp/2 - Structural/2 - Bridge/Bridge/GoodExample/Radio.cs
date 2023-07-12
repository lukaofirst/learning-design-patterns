namespace Bridge.GoodExample
{
	public class Radio : IDevice
	{
		public void TurnOn()
		{
			Console.WriteLine("Radio turned on");
		}

		public void TurnOff()
		{
			Console.WriteLine("Radio turned off");
		}
	}
}