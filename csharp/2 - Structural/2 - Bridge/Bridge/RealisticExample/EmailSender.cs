using Bridge.RealisticExample.Interfaces;

namespace Bridge.RealisticExample
{
	public class EmailSender : IMessageSender
	{
		public void SendMessage(string subject, string body)
		{
			Console.WriteLine($"Sending email with subject: {subject} and body: {body}");
		}
	}
}