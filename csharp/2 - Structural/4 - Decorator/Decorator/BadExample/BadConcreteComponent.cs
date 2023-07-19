using Decorator.Common.Interfaces;

namespace Decorator.BadExample
{
	public class BadConcreteComponent : IComponent
	{
		public string Operation()
		{
			return nameof(BadConcreteComponent);
		}
	}
}