namespace Visitor.GoodExample.Interfaces
{
	public interface IGoodVisitable
	{
		void Accept(IGoodVisitor visitor);
	}
}