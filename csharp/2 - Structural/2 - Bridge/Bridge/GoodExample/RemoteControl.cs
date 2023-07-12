namespace Bridge.GoodExample
{
	public abstract class RemoteControl
	{
		private readonly IDevice _device;

		public RemoteControl(IDevice device)
		{
			_device = device;
		}

		public abstract void On();
		public abstract void Off();
	}
}