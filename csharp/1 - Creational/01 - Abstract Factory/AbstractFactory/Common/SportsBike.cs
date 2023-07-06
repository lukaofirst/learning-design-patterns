using AbstractFactory.Common.Interfaces;

namespace AbstractFactory.Common
{
	public class SportsBike : IBike
	{
		public string GetBikeName()
		{
			return "Sports Bike";
		}
	}
}