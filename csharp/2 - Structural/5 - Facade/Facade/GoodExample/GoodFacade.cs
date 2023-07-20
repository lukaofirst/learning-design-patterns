namespace Facade.GoodExample
{
	public class GoodFacade
	{
		private readonly GoodSubsystemA _goodSubsystemA;
		private readonly GoodSubsystemB _goodSubsystemB;
		private readonly GoodSubsystemC _goodSubsystemC;

		public GoodFacade()
		{
			_goodSubsystemA = new GoodSubsystemA();
			_goodSubsystemB = new GoodSubsystemB();
			_goodSubsystemC = new GoodSubsystemC();
		}

		public void StartEngine()
		{
			_goodSubsystemA.Initialize();
			_goodSubsystemB.Configure();
			_goodSubsystemC.Start();
		}

		public void StopEngine()
		{
			_goodSubsystemC.Stop();
			_goodSubsystemB.Deconfigure();
			_goodSubsystemA.Deinitialize();
		}
	}
}