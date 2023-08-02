namespace TemplateMethod.BadExample
{
	public class BadConcreteClass : BadTemplateMethod
	{
		public override void Operation1()
		{
			Console.WriteLine("Performing Operation1");
		}

		public override void Operation2()
		{
			Console.WriteLine("Performing Operation2");
		}

		public override void Operation3()
		{
			Console.WriteLine("Performing Operation3");
		}
	}
}