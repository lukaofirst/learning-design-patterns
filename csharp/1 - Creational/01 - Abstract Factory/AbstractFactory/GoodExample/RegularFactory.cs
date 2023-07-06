using AbstractFactory.Common;
using AbstractFactory.Common.Interfaces;

namespace AbstractFactory.GoodExample
{
	public class RegularFactory : IGoodVehicleFactory
	{
		public ICar CreateCar()
		{
			return new RegularCar();
		}

		public IBike CreateBike()
		{
			return new RegularBike();
		}
	}
}