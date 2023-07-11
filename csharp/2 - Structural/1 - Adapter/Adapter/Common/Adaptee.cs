namespace Adapter.Common
{
	public class Adaptee
	{
		public void SpecificRequest()
		{
			Console.WriteLine($"Calling {nameof(SpecificRequest)}");
		}
	}
}