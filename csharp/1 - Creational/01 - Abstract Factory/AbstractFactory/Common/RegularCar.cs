using AbstractFactory.Common.Interfaces;

namespace AbstractFactory.Common
{
	public class RegularCar : ICar
	{
		public string GetCarName()
		{
			return "Regular Car";
		}
	}
}