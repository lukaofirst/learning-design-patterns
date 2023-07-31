namespace Observer.GoodExample
{
	public class GoodObserver : IObserver<int>
	{
		private IDisposable? _unsubscriber;

		public void Subscribe(IObservable<int> provider)
		{
			if (provider != null)
			{
				_unsubscriber = provider.Subscribe(this);
			}
		}

		public void OnCompleted()
		{
			Unsubscribe();
		}

		public void OnError(Exception error)
		{

		}

		public void OnNext(int value)
		{
			Console.WriteLine($"State changed to: {value}");
		}

		public void Unsubscribe()
		{
			if (_unsubscriber != null)
				_unsubscriber!.Dispose();
		}
	}
}