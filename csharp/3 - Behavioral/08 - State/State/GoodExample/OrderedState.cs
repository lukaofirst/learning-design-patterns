using State.GoodExample.Interfaces;

namespace State.GoodExample
{
	public class OrderedState : IPackageState
	{
		public void PrintDeliveryStatus()
		{
			Console.WriteLine("Package ordered, not delivered yet");
		}
	}
}