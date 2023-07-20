using Facade.RealisticExample.Entities;

namespace Facade.RealisticExample.Services
{
	public class InventoryService
	{
		public bool IsProductAvailable(Product product)
		{
			Console.WriteLine($"Checking availability of product: {product.Name}");

			return true;
		}
	}
}