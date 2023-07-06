using FactoryMethod.Common.Interfaces;
using FactoryMethod.RealisticExample.Interfaces;

namespace FactoryMethod.RealisticExample
{
	public class RealisticCarFactory : IRealisticCarFactory
	{
		private readonly Dictionary<string, Func<ICar>> _factories;

		public RealisticCarFactory()
		{
			_factories = new();
		}

		public IRealisticCarFactory Register(string type, Func<ICar> factory)
		{
			_factories[type] = factory;
			return this;
		}

		public ICar Create(string type)
		{
			if (_factories.ContainsKey(type))
			{
				return _factories[type].Invoke();
			}
			else
			{
				throw new Exception("Invalid car type");
			}
		}
	}
}