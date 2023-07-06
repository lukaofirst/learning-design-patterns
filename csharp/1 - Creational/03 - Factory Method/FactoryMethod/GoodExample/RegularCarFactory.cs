using FactoryMethod.Common.Interfaces;
using FactoryMethod.GoodExample.Interfaces;

namespace FactoryMethod.GoodExample
{
	public class RegularCarFactory : IGoodCarFactory
	{
		public ICar CreateCar()
		{
			return new RegularCar();
		}
	}
}