using Adapter.Common;

namespace Adapter.BadExample
{
	public class BadAdapter : Adaptee, IAdapter
	{
		public void Request()
		{
			SpecificRequest();
		}
	}
}