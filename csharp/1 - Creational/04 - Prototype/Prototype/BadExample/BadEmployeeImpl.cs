namespace Prototype.BadExample
{
	public class BadEmployeeImpl
	{
		public string? Name { get; set; }
		public string? Department { get; set; }

		public BadEmployeeImpl Clone()
		{
			return this;
		}
	}
}