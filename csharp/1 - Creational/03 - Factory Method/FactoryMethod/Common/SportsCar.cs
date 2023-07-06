using FactoryMethod.Common.Interfaces;

namespace FactoryMethod.Common
{
	public class SportsCar : ICar
	{
		public string GetCarName()
		{
			return "Sports Car";
		}
	}
}