using AbstractFactory.Common;
using AbstractFactory.Common.Interfaces;

namespace AbstractFactory.GoodExample
{
	public class SportsFactory : IGoodVehicleFactory
	{
		public ICar CreateCar()
		{
			return new SportsCar();
		}

		public IBike CreateBike()
		{
			return new SportsBike();
		}
	}
}