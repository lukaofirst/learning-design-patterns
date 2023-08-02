namespace Observer.GoodExample
{
	public class GoodSubject : IObservable<int>
	{
		private readonly List<IObserver<int>> _observers;
		private int _state;

		public GoodSubject()
		{
			_observers = new List<IObserver<int>>();
			_state = 0;
		}

		public IDisposable Subscribe(IObserver<int> observer)
		{
			if (!_observers.Contains(observer))
				_observers.Add(observer);

			return new Unsubscriber(_observers, observer);
		}

		public void NotifyObservers()
		{
			foreach (var observer in _observers)
			{
				observer.OnNext(_state);
			}
		}

		public void SetState(int state)
		{
			_state = state;
			NotifyObservers();
		}

		private class Unsubscriber : IDisposable
		{
			private readonly List<IObserver<int>> _observers;
			private readonly IObserver<int> _observer;

			public Unsubscriber(List<IObserver<int>> observers, IObserver<int> observer)
			{
				_observers = observers;
				_observer = observer;
			}

			public void Dispose()
			{
				if (_observer != null && _observers.Contains(_observer))
					_observers.Remove(_observer);
			}
		}
	}
}