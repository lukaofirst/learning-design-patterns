using FactoryMethod.Common.Interfaces;

namespace FactoryMethod.RealisticExample.Interfaces
{
	public interface IRealisticCarFactory
	{
		IRealisticCarFactory Register(string type, Func<ICar> factory);
		ICar Create(string type);
	}
}