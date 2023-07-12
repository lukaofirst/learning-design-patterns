using Bridge.RealisticExample.Interfaces;

namespace Bridge.RealisticExample
{
	public class SmsSender : IMessageSender
	{
		public void SendMessage(string subject, string body)
		{
			Console.WriteLine($"Sending sms with subject: {subject} and body: {body}");
		}
	}
}