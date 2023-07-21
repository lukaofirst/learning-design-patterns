using Proxy.Common.Interfaces;

namespace Proxy.GoodExample
{
	public class GoodProxy : IService
	{
		private readonly IService _service;

		public GoodProxy(IService service)
		{
			_service = service;
		}

		public void Request()
		{
			Console.WriteLine("Good Proxy: Checking access prior to firing a real request");

			if (CheckAccess())
			{
				_service.Request();
				LogAccess();
			}
		}

		private static bool CheckAccess()
		{
			Console.WriteLine("Good Proxy: Checking access");
			return true;
		}

		private static void LogAccess()
		{
			Console.WriteLine("Good Proxy: Logging access");
		}
	}
}