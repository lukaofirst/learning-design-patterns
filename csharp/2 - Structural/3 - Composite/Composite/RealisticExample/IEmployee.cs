namespace Composite.RealisticExample
{
	public interface IEmployee
	{
		public string Name { get; set; }
		public void Display(int indent);
	}
}