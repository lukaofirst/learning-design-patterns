using Visitor.BadExample.Interfaces;

namespace Visitor.BadExample
{
	public class BadConcreteVisitor1 : IBadVisitor
	{
		public void VisitConcreteElementA(BadConcreteElementA concreteElementA)
		{
			Console.WriteLine("BadConcreteVisitor1 visited BadConcreteElementA");
		}

		public void VisitConcreteElementB(BadConcreteElementB concreteElementB)
		{
			Console.WriteLine("BadConcreteVisitor1 visited BadConcreteElementB");
		}
	}
}