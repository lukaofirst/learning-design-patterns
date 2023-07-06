using Builder.Common;

namespace Builder.BadExample
{
	public class BadCarBuilder
	{
		private readonly Car _car;

		public BadCarBuilder()
		{
			_car = new Car();
		}

		public BadCarBuilder SetName(string name)
		{
			_car.Name = name;
			return this;
		}

		public BadCarBuilder SetColor(string color)
		{
			_car.Color = color;
			return this;
		}

		public BadCarBuilder SetHorsePower(int horsePower)
		{
			_car.HousePower = horsePower;
			return this;
		}

		public Car Build()
		{
			return _car;
		}
	}
}