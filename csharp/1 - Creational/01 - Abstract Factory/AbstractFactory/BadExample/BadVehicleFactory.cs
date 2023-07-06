using AbstractFactory.Common;
using AbstractFactory.Common.Enums;
using AbstractFactory.Common.Interfaces;

namespace AbstractFactory.BadExample
{
	public class BadVehicleFactory
	{
		public static ICar CreateCar(VehicleFactoryType type)
		{
			return type switch
			{
				VehicleFactoryType.Sports => new SportsCar(),
				VehicleFactoryType.Regular => new RegularCar(),
				_ => throw new NotImplementedException(),
			};
		}

		public static IBike CreateBike(VehicleFactoryType type)
		{
			return type switch
			{
				VehicleFactoryType.Sports => new SportsBike(),
				VehicleFactoryType.Regular => new RegularBike(),
				_ => throw new NotImplementedException(),
			};
		}
	}
}