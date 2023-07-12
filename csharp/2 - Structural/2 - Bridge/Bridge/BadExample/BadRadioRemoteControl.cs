namespace Bridge.BadExample
{
	public class BadRadioRemoteControl : BadRemoteControl
	{
		public override void TurnOn()
		{
			Console.WriteLine("Radio turned on");
		}

		public override void TurnOff()
		{
			Console.WriteLine("Radio turned off");
		}
	}
}