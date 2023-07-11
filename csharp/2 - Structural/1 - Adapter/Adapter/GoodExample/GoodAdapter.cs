using Adapter.Common;

namespace Adapter.GoodExample
{
	public class GoodAdapter : IAdapter
	{
		private readonly Adaptee _adaptee;

		public GoodAdapter(Adaptee adaptee)
		{
			_adaptee = adaptee;
		}

		public void Request()
		{
			_adaptee.SpecificRequest();
		}
	}
}