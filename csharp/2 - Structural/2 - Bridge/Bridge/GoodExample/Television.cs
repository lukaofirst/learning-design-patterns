namespace Bridge.GoodExample
{
	public class Television : IDevice
	{
		public void TurnOn()
		{
			Console.WriteLine("Television turned on");
		}

		public void TurnOff()
		{
			Console.WriteLine("Television turned off");
		}
	}
}