namespace Visitor.BadExample.Interfaces
{
	public interface IBadElement
	{
		void Accept(IBadVisitor visitor);
	}
}