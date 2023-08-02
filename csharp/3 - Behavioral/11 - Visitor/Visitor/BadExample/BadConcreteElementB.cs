using Visitor.BadExample.Interfaces;

namespace Visitor.BadExample
{
	public class BadConcreteElementB : IBadElement
	{
		public void Accept(IBadVisitor visitor)
		{
			visitor.VisitConcreteElementB(this);
		}
	}
}