namespace Prototype.GoodExample
{
	public class GoodEmployeeImpl
	{
		public string? Name { get; set; }
		public string? Department { get; set; }

		public GoodEmployeeImpl Clone()
		{
			return new GoodEmployeeImpl
			{
				Name = Name,
				Department = Department
			};
		}
	}
}