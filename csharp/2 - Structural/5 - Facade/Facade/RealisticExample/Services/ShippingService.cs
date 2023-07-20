using Facade.RealisticExample.Entities;

namespace Facade.RealisticExample.Services
{
	public class ShippingService
	{
		public bool ShipOrder(Order order)
		{
			Console.WriteLine($"Shipping order to customer: {order.Customer!.Name}");

			return true;
		}
	}
}