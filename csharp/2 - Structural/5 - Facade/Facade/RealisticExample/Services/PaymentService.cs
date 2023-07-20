using Facade.RealisticExample.Entities;

namespace Facade.RealisticExample.Services
{
	public class PaymentService
	{
		public bool ProcessPayment(Order order)
		{
			Console.WriteLine($"Processing payment for order: {order.TotalPrice}");

			return true;
		}
	}
}