namespace TemplateMethod.GoodExample
{
	public abstract class GoodTemplateMethod
	{
		public void TemplateMethod()
		{
			Operation1();
			Operation2();
			Operation3();
		}

		public virtual void Operation1()
		{
			Console.WriteLine("Performing Operation1");
		}

		public virtual void Operation2()
		{
			Console.WriteLine("Performing Operation2");
		}

		public virtual void Operation3()
		{
			Console.WriteLine("Performing Operation3");
		}
	}
}