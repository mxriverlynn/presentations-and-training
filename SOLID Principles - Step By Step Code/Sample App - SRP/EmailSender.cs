using System.IO;
using System.Net;
using System.Net.Mail;

namespace SOLID.SampleApp
{
	public class EmailSender
	{
	
		public string MessageBody { get; set; }

		public string FileName { get; set; }

		public void ReadFile()
		{
			FileInfo file = new FileInfo(FileName);
			StreamReader rdr = file.OpenText();
			string fileContents = rdr.ReadToEnd();
			rdr.Dispose();
			
			FormatReader formatReader = new FormatReader();
			MessageBody = formatReader.GetMessageBody(fileContents);
		}

		public void SendEmail()
		{
			SmtpClient client = new SmtpClient("some.mail.server.example.com");
			client.Credentials = new NetworkCredential("someuser", "somepassword");
			MailAddress from = new MailAddress("me@myserver.com");
			MailAddress to = new MailAddress("derick.bailey@mlcaneat.com");
			MailMessage msg = new MailMessage(from, to);
			msg.Body = MessageBody;
			msg.Subject = "Test message";
			//client.Send(msg);
		}
		
	}
}
