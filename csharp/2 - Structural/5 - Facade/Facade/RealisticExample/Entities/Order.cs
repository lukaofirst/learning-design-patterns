namespace Facade.RealisticExample.Entities
{
	public class Order
	{
		public Customer? Customer { get; set; }
		public List<Product> Products { get; set; }
		public double TotalPrice { get; set; }

		public Order(Customer customer, List<Product> products, double totalPrice)
		{
			Customer = customer;
			Products = products;
			TotalPrice = totalPrice;
		}
	}
}