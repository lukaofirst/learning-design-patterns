using State.GoodExample.Interfaces;

namespace State.GoodExample
{
	public class DeliveredState : IPackageState
	{
		public void PrintDeliveryStatus()
		{
			Console.WriteLine("Package delivered to post office, not received yet");
		}
	}
}