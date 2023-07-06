using FactoryMethod.BadExample.Interfaces;
using FactoryMethod.Common;
using FactoryMethod.Common.Interfaces;

namespace FactoryMethod.BadExample
{
	public class BadCarFactory : IBadCarFactory
	{
		public ICar CreateCar(string type)
		{
			if (type == "Regular")
			{
				return new RegularCar();
			}
			else if (type == "Sports")
			{
				return new SportsCar();
			}
			else
			{
				throw new Exception("Invalid car type");
			}
		}
	}
}