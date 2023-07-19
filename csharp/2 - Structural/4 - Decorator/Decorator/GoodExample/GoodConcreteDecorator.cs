using Decorator.Common.Interfaces;

namespace Decorator.GoodExample
{
	public class GoodConcreteDecorator : GoodDecorator
	{
		public GoodConcreteDecorator(IComponent component) : base(component)
		{

		}

		public override string Operation()
		{
			return $"{nameof(GoodConcreteDecorator)}({base.Operation()})";
		}
	}
}