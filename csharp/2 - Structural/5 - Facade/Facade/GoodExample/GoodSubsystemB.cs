namespace Facade.GoodExample
{
	public class GoodSubsystemB
	{
		public void Configure()
		{
			Console.WriteLine("SubsystemB: Configuring...");
		}

		public void Deconfigure()
		{
			Console.WriteLine("SubsystemB: Deconfiguring...");
		}
	}
}