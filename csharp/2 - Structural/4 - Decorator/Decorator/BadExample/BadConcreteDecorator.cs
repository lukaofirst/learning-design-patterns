using Decorator.Common.Interfaces;

namespace Decorator.BadExample
{
	public class BadConcreteDecorator : IComponent
	{
		private readonly IComponent? _component;

		public BadConcreteDecorator(IComponent component)
		{
			_component = null;
		}

		public string Operation()
		{
			return $"{nameof(BadConcreteDecorator)}({_component!.Operation()})";
		}
	}
}