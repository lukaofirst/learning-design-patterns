using Interpreter.GoodExample.Expressions;
using Interpreter.GoodExample.Interfaces;

namespace Interpreter.GoodExample
{
	public class GoodInterpreter
	{
		private readonly Dictionary<string, IExpression> _expressions;

		public GoodInterpreter()
		{
			_expressions = new()
			{
				{ "A", new TerminalExpressionA() },
				{ "B", new TerminalExpressionB() }
			};
		}

		public string Interpret(string input)
		{
			if (_expressions.ContainsKey(input))
				return _expressions[input].Interpret();
			else
				return "Invalid input";
		}
	}
}