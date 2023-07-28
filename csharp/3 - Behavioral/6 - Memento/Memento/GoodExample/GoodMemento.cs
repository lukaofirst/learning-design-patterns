namespace Memento.GoodExample
{
	public class GoodMemento
	{
		public string State { get; private set; }

		public GoodMemento(string state)
		{
			State = state;
		}
	}
}