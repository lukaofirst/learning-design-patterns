namespace Mediator.BadExample
{
	public class BadUser
	{
		private readonly BadMediator _badMediator;
		private readonly string _name;

		public BadUser(string name, BadMediator badMediator)
		{
			_name = name;
			_badMediator = badMediator;
		}

		public void Send(string message)
		{
			Console.WriteLine($"{_name}: {message}");
			_badMediator.Send(message, this);
		}

		public void Receive(string message, BadUser sender)
		{
			Console.WriteLine($"{_name} received from {sender._name}: {message}");
		}
	}
}