using AbstractFactory.Common.Interfaces;

namespace AbstractFactory.Common
{
	public class RegularBike : IBike
	{
		public string GetBikeName()
		{
			return "Regular Bike";
		}
	}
}