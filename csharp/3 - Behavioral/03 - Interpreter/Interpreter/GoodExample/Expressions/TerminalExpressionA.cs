using Interpreter.GoodExample.Interfaces;

namespace Interpreter.GoodExample.Expressions
{
	public class TerminalExpressionA : IExpression
	{
		public string Interpret()
		{
			return "This is A";
		}
	}
}