using Visitor.BadExample.Interfaces;

namespace Visitor.BadExample
{
	public class BadConcreteVisitor2 : IBadVisitor
	{
		public void VisitConcreteElementA(BadConcreteElementA concreteElementA)
		{
			Console.WriteLine("BadConcreteVisitor2 visited BadConcreteElementA");
		}

		public void VisitConcreteElementB(BadConcreteElementB concreteElementB)
		{
			Console.WriteLine("BadConcreteVisitor2 visited BadConcreteElementB");
		}
	}
}