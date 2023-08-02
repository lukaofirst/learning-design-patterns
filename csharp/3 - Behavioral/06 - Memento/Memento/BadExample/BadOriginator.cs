using Memento.Common;

namespace Memento.BadExample
{
	public class BadOriginator
	{
		public string? State { get; set; }

		public void SetState(string state)
		{
			State = state;
			Console.WriteLine($"Originator: Setting state to {State}");
		}

		public BadMemento CreateMemento()
		{
			Console.WriteLine("Originator: Saving to Memento");
			return new BadMemento(State!);
		}

		public void RestoreFromMemento(BadMemento memento)
		{
			State = memento.State;
			Console.WriteLine($"Originator: State after restoring from Memento: {State}");
		}
	}
}