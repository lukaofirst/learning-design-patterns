using FactoryMethod.Common;
using FactoryMethod.Common.Interfaces;
using FactoryMethod.GoodExample.Interfaces;

namespace FactoryMethod.GoodExample
{
	public class SportsCarFactory : IGoodCarFactory
	{
		public ICar CreateCar()
		{
			return new SportsCar();
		}
	}
}