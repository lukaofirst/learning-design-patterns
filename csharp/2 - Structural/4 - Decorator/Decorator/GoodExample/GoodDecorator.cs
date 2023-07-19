using Decorator.Common.Interfaces;

namespace Decorator.GoodExample
{
	public abstract class GoodDecorator : IComponent
	{
		private readonly IComponent _component;

		public GoodDecorator(IComponent component)
		{
			_component = component;
		}

		public virtual string Operation()
		{
			return _component.Operation();
		}
	}
}