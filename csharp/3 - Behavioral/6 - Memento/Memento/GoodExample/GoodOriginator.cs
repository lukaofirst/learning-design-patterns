namespace Memento.GoodExample
{
	public class GoodOriginator
	{
		private string? _state;

		public void SetState(string state)
		{
			_state = state;
			Console.WriteLine($"Originator: Setting state to {_state}");
		}

		public GoodMemento CreateMemento()
		{
			Console.WriteLine("Originator: Saving to Memento");
			return new GoodMemento(_state!);
		}

		public void RestoreFromMemento(GoodMemento memento)
		{
			_state = memento.State;
			Console.WriteLine($"Originator: State after restoring from Memento: {_state}");
		}
	}
}