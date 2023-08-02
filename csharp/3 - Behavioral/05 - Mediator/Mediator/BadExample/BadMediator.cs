namespace Mediator.BadExample
{
	public class BadMediator
	{
		public List<BadUser> _users = new();

		public void Register(BadUser user)
		{
			_users.Add(user);
		}

		public void Send(string message, BadUser sender)
		{
			foreach (var user in _users)
				user.Receive(message, sender);
		}
	}
}