namespace Bridge.GoodExample
{
	public class BasicRemoteControl : RemoteControl
	{
		private readonly IDevice _device;

		public BasicRemoteControl(IDevice device) : base(device)
		{
			_device = device;
		}

		public override void On()
		{
			_device.TurnOn();
		}

		public override void Off()
		{
			_device.TurnOff();
		}
	}
}