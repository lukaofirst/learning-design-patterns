namespace Mediator.GoodExample
{
	public class GoodUser
	{
		private readonly GoodMediator _goodMediator;
		private readonly string _name;

		public GoodUser(string name, GoodMediator goodMediator)
		{
			_name = name;
			_goodMediator = goodMediator;
		}

		public void Send(string message)
		{
			Console.WriteLine($"{_name}: {message}");
			_goodMediator.Send(message, this);
		}

		public void Receive(string message, GoodUser sender)
		{
			Console.WriteLine($"{_name} received from {sender._name}: {message}");
		}
	}
}