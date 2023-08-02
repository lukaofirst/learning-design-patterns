namespace Interpreter.BadExample
{
	public class BadInterpreter
	{
		public string Interpret(string input)
		{
			string result = string.Empty;

			switch (input)
			{
				case "A":
					result = "This is A";
					break;
				case "B":
					result = "This is B";
					break;
				default:
					break;
			}

			return result;
		}
	}
}