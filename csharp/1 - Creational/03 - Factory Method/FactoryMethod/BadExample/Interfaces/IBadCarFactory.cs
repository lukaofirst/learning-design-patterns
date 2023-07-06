using FactoryMethod.Common.Interfaces;

namespace FactoryMethod.BadExample.Interfaces
{
	public interface IBadCarFactory
	{
		ICar CreateCar(string type);
	}
}