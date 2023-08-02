namespace TemplateMethod.GoodExample
{
	public class GoodConcreteClass : GoodTemplateMethod
	{
		// Tip: If type "override", the IDE will show you the available options to override a method
		public override void Operation2()
		{
			Console.WriteLine("Performing an overrided Operation2");
		}
	}
}