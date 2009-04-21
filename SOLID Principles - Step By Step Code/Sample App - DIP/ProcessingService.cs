namespace SOLID.SampleApp
{
	public class ProcessingService
	{
	
		private readonly IEmailSender _emailSender;
		private readonly IMessageInfoRetriever _messageInfoRetriever;

		public ProcessingService(IEmailSender emailSender, IMessageInfoRetriever messageInfoRetriever)
		{
			_emailSender = emailSender;
			_messageInfoRetriever = messageInfoRetriever;
		}

		public string SendMessage()
		{
			string messageBody = _messageInfoRetriever.GetMessageBody();
			_emailSender.SendEmail(messageBody);
			return "Send Email With Body: " + messageBody;
		}
		
	}
}
