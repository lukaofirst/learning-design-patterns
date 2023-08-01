using State.GoodExample.Interfaces;

namespace State.GoodExample
{
	public class ReceivedState : IPackageState
	{
		public void PrintDeliveryStatus()
		{
			Console.WriteLine("Package received by client");
		}
	}
}