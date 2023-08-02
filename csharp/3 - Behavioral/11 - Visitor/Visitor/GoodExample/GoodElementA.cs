using Visitor.GoodExample.Interfaces;

namespace Visitor.GoodExample
{
	public class GoodElementA : IGoodVisitable
	{
		public int Value { get; set; }

		public GoodElementA(int value)
		{
			Value = value;
		}

		public void Accept(IGoodVisitor visitor)
		{
			visitor.Visit(this);
		}
	}
}