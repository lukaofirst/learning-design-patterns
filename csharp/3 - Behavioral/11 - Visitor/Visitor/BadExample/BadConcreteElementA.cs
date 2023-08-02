using Visitor.BadExample.Interfaces;

namespace Visitor.BadExample
{
	public class BadConcreteElementA : IBadElement
	{
		public void Accept(IBadVisitor visitor)
		{
			visitor.VisitConcreteElementA(this);
		}
	}
}