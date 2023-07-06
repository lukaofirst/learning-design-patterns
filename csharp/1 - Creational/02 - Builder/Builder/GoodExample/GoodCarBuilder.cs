using Builder.Common;

namespace Builder.GoodExample
{
	public class GoodCarBuilder
	{
		private string? _name;
		private string? _color;
		private int _horsePower;

		public GoodCarBuilder SetName(string name)
		{
			if (string.IsNullOrEmpty(name))
				throw new ArgumentNullException(nameof(name), "Name cannot be null or empty");

			_name = name;

			return this;
		}

		public GoodCarBuilder SetColor(string color)
		{
			if (string.IsNullOrEmpty(color))
				throw new ArgumentNullException(nameof(color), "Color cannot be null or empty");

			_color = color;

			return this;
		}

		public GoodCarBuilder SetHorsePower(int horsePower)
		{
			if (horsePower <= 0)
				throw new ArgumentNullException(nameof(horsePower), "HorsePower must be greater than 0");

			_horsePower = horsePower;

			return this;
		}

		public Car Build()
		{
			return new Car(_name, _color, _horsePower);
		}
	}
}