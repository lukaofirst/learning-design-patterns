namespace ChainOfResponsability.BadExample
{
	public class BadHandler
	{
		public void HandlerRequest(string requestType)
		{
			if (requestType == "TypeA")
			{
				Console.WriteLine("Handling TypeA type requests");
			}
			else if (requestType == "TypeB")
			{
				Console.WriteLine("Handling TypeB type requests");
			}
			else
			{
				Console.WriteLine("Handling other types of requests");
			}
		}
	}
}