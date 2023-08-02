namespace Visitor.GoodExample.Interfaces
{
	public interface IGoodVisitor
	{
		void Visit(GoodElementA element);
		void Visit(GoodElementB element);
	}
}