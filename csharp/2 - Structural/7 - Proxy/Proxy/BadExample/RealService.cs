using Proxy.Common.Interfaces;

namespace Proxy.BadExample
{
	public class RealService : IService
	{
		public void Request()
		{
			Console.WriteLine($"{nameof(RealService)}: Executing request");
		}
	}
}