using Facade.RealisticExample.Entities;
using Facade.RealisticExample.Services;

namespace Facade.RealisticExample
{
	public class OrderFacade
	{
		private readonly InventoryService _inventoryService;
		private readonly PaymentService _paymentService;
		private readonly ShippingService _shippingService;

		public OrderFacade()
		{
			_inventoryService = new InventoryService();
			_paymentService = new PaymentService();
			_shippingService = new ShippingService();
		}

		public bool PlaceOrder(Order order)
		{
			foreach (var product in order.Products!)
			{
				if (!_inventoryService.IsProductAvailable(product))
				{
					Console.WriteLine($"Product not available: {product.Name}");
					return false;
				}
			}

			if (!_paymentService.ProcessPayment(order))
			{
				Console.WriteLine("Payment failed");
				return false;
			}

			if (!_shippingService.ShipOrder(order))
			{
				Console.WriteLine("Shipping failed");
				return false;
			}

			Console.WriteLine("Order placed successfully");
			return true;
		}
	}
}