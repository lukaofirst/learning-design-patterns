using Bridge.RealisticExample.Interfaces;

namespace Bridge.RealisticExample
{
	public class TextMessage : IMessage
	{
		private readonly IMessageSender _messageSender;
		private readonly string _subject;
		private readonly string _body;

		public TextMessage(IMessageSender messageSender, string subject, string body)
		{
			_body = body;
			_subject = subject;
			_messageSender = messageSender;
		}

		public void Send()
		{
			_messageSender.SendMessage(_subject, _body);
		}
	}
}