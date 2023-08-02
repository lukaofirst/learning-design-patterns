using Interpreter.GoodExample.Interfaces;

namespace Interpreter.GoodExample.Expressions
{
	public class TerminalExpressionB : IExpression
	{
		public string Interpret()
		{
			return "This is B";
		}
	}
}