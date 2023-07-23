namespace ChainOfResponsability.GoodExample.Interfaces
{
	public interface IHandler
	{
		IHandler SetSuccessor(IHandler successor);
		void HandlerRequest(string requestType);
	}
}