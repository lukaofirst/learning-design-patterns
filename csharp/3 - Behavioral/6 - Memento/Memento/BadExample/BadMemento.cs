namespace Memento.Common
{
	public class BadMemento
	{
		public string? State { get; set; }

		public BadMemento(string state)
		{
			State = state;
		}
	}
}