namespace Mediator.GoodExample
{
	public class GoodMediator
	{
		private readonly List<GoodUser> _users = new();

		public void Register(GoodUser user)
		{
			_users.Add(user);
		}

		public void Send(string message, GoodUser sender)
		{
			foreach (var user in _users)
			{
				if (user != sender)
					user.Receive(message, sender);
			}
		}
	}
}