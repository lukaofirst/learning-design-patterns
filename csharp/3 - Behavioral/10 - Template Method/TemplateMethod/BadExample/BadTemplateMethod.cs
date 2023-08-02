namespace TemplateMethod.BadExample
{
	public abstract class BadTemplateMethod
	{
		public void TemplateMethod()
		{
			Operation1();
			Operation2();
			Operation3();
		}

		public abstract void Operation1();
		public abstract void Operation2();
		public abstract void Operation3();
	}
}