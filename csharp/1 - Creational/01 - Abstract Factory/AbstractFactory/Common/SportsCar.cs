using AbstractFactory.Common.Interfaces;

namespace AbstractFactory.Common
{
	public class SportsCar : ICar
	{
		public string GetCarName()
		{
			return "Sports Car";
		}
	}
}