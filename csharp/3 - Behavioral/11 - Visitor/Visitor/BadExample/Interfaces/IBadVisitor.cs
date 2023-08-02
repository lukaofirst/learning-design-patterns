
namespace Visitor.BadExample.Interfaces
{
	public interface IBadVisitor
	{
		void VisitConcreteElementA(BadConcreteElementA concreteElementA);
		void VisitConcreteElementB(BadConcreteElementB concreteElementB);
	}
}