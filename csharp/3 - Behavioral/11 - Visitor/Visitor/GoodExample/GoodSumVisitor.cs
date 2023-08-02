using Visitor.GoodExample.Interfaces;

namespace Visitor.GoodExample
{
	public class GoodSumVisitor : IGoodVisitor
	{
		public int Sum { get; private set; } = 0;

		public void Visit(GoodElementA element)
		{
			Sum += element.Value;
		}

		public void Visit(GoodElementB element)
		{
			_ = int.TryParse(element.Text, out int result);
			Sum += result;
		}
	}
}