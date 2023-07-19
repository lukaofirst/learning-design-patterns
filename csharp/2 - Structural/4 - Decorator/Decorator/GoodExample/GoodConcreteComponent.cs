using Decorator.Common.Interfaces;

namespace Decorator.GoodExample
{
	public class GoodConcreteComponent : IComponent
	{
		public string Operation()
		{
			return nameof(GoodConcreteComponent);
		}
	}
}