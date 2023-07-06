using AbstractFactory.Common.Interfaces;

namespace AbstractFactory.GoodExample
{
	public interface IGoodVehicleFactory
	{
		ICar CreateCar();
		IBike CreateBike();
	}
}