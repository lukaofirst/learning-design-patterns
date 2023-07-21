using Proxy.Common.Interfaces;

namespace Proxy.BadExample
{
	public class BadProxy : IService
	{
		private readonly RealService _realService;

		public BadProxy(RealService realService)
		{
			_realService = realService;
		}

		public void Request()
		{
			Console.WriteLine($"{nameof(BadProxy)}: Forwarding request to RealService");
			_realService.Request();
		}
	}
}