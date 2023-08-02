using Visitor.GoodExample.Interfaces;

namespace Visitor.GoodExample
{
	public class GoodElementB : IGoodVisitable
	{
		public string Text { get; set; }

		public GoodElementB(string text)
		{
			Text = text;
		}

		public void Accept(IGoodVisitor visitor)
		{
			visitor.Visit(this);
		}
	}
}