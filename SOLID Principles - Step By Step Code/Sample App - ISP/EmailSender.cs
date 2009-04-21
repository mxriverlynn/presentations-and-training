using System.Net;
using System.Net.Mail;

namespace SOLID.SampleApp
{
	public class EmailSender
	{

		public void SendEmail(string messageBody)
		{
			SmtpClient client = new SmtpClient("some.mail.server.example.com");
			client.Credentials = new NetworkCredential("someuser", "somepassword");
			MailAddress from = new MailAddress("me@myserver.com");
			MailAddress to = new MailAddress("derick.bailey@mlcaneat.com");
			MailMessage msg = new MailMessage(from, to);
			msg.Body = messageBody;
			msg.Subject = "Test message";
			//client.Send(msg);
		}

	}
}
