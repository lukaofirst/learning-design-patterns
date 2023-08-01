using State.GoodExample.Interfaces;

namespace State.GoodExample
{
	public class GoodPackage
	{
		public IPackageState? State { get; set; }

		public void PrintDeliveryStatus()
		{
			State!.PrintDeliveryStatus();
		}
	}
}