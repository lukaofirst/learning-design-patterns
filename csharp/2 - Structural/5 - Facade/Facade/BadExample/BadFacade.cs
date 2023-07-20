namespace Facade.BadExample
{
	public class BadFacade
	{
		private readonly BadSubsystemA _badSubsystemA;
		private readonly BadSubsystemB _badSubsystemB;
		private readonly BadSubsystemC _badSubsystemC;

		public BadFacade()
		{
			_badSubsystemA = new BadSubsystemA();
			_badSubsystemB = new BadSubsystemB();
			_badSubsystemC = new BadSubsystemC();
		}

		public void Operation1()
		{
			_badSubsystemA.Operation1();
			_badSubsystemB.Operation1();
			_badSubsystemC.Operation1();
		}

		public void Operation2()
		{
			_badSubsystemA.Operation2();
			_badSubsystemB.Operation2();
			_badSubsystemC.Operation2();
		}
	}
}