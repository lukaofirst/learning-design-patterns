

namespace Bridge.BadExample
{
	public class BadTelevisionRemoteControl : BadRemoteControl
	{
		public override void TurnOn()
		{
			Console.WriteLine("Television turned on");
		}

		public override void TurnOff()
		{
			Console.WriteLine("Television turned off");
		}
	}
}