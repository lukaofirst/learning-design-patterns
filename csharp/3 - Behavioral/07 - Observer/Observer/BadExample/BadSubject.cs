namespace Observer.BadExample
{
	public class BadSubject
	{
		private readonly List<BadObserver> _observers;
		private int _state;

		public BadSubject()
		{
			_observers = new List<BadObserver>();
			_state = 0;
		}

		public void Attach(BadObserver observer)
		{
			_observers.Add(observer);
		}

		public void Detach(BadObserver observer)
		{
			_observers.Remove(observer);
		}

		public void NotifyObservers()
		{
			foreach (var observer in _observers)
			{
				observer.Update(_state);
			}
		}

		public void SetState(int state)
		{
			_state = state;
			NotifyObservers();
		}
	}
}