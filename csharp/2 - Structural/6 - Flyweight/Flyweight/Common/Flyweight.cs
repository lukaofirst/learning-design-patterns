namespace Flyweight.Common
{
	public class CommonFlyweight
	{
		private readonly string _intrinsicState;

		public CommonFlyweight(string intrinsicState)
		{
			_intrinsicState = intrinsicState;
		}

		public void Operation(string extrinsicState)
		{
			Console.WriteLine($"IntrinsicState: {_intrinsicState}, ExtrinsicState: {extrinsicState}");
		}
	}
}