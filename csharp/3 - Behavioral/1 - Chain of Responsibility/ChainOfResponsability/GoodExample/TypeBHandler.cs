using ChainOfResponsability.GoodExample.Interfaces;

namespace ChainOfResponsability.GoodExample
{
	public class TypeBHandler : IHandler
	{
		private IHandler? _successor;

		public IHandler SetSuccessor(IHandler successor)
		{
			_successor = successor;

			return _successor;
		}

		public void HandlerRequest(string requestType)
		{
			if (requestType == "TypeB")
			{
				Console.WriteLine("Handling TypeB type requests");
			}
			else if (_successor != null)
			{
				_successor.HandlerRequest(requestType);
			}
		}
	}
}