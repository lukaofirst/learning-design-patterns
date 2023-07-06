namespace Builder.Common
{
	public record Car
	{
		public string? Name { get; set; }
		public string? Color { get; set; }
		public int HousePower { get; set; }

		public Car()
		{

		}

		public Car(string? name, string? color, int horsePower)
		{
			Name = name;
			Color = color;
			HousePower = horsePower;
		}
	}
}