namespace State.BadExample
{
	public class BadPackage
	{
		public enum PackageStateEnum { Ordered, Delivered, Received }
		public PackageStateEnum? State { get; set; }

		public void PrintDeliveryStatus()
		{
			if (State == PackageStateEnum.Ordered)
				Console.WriteLine("Package ordered, not delivered yet");
			else if (State == PackageStateEnum.Delivered)
				Console.WriteLine("Package delivered to post office, not received yet");
			else if (State == PackageStateEnum.Received)
				Console.WriteLine("Package received by client");
		}
	}
}