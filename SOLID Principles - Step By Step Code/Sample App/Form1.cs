using System;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace SOLID.SampleApp
{

	public partial class Form1 : Form
	{
	
		private string _file;

		public Form1()
		{
			InitializeComponent();
		}

		private void Send_Click(object sender, EventArgs e)
		{
			try
			{
				Output.Text = string.Empty;
				FileInfo file = new FileInfo(_file);
				StreamReader rdr = file.OpenText();
				string messageBody = rdr.ReadToEnd();
				rdr.Dispose();

				SmtpClient client = new SmtpClient("some.mail.server.example.com");
				client.Credentials = new NetworkCredential("someuser", "somepassword");
				MailAddress from = new MailAddress("me@myserver.com");
				MailAddress to = new MailAddress("derick.bailey@mlcaneat.com");
				MailMessage msg = new MailMessage(from, to);
				msg.Body = messageBody;
				msg.Subject = "Test message";
				//client.Send(msg);

				Output.Text = "Sent email with body: " + Environment.NewLine + messageBody;
			}
			catch (Exception ex)
			{
				Output.Text = ex.ToString();
			}
		}

		private void FindFile_Click(object sender, EventArgs e)
		{
			try
			{
				Output.Text = string.Empty;
				OpenFileDialog dlg = new OpenFileDialog();
				dlg.CheckFileExists = true;
				dlg.CheckPathExists = true;
				dlg.Filter = "Text Files (*.txt)|*.txt";
				if (dlg.ShowDialog() == DialogResult.OK)
				{
					_file = dlg.FileName;
					SelectedFile.Text = _file;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

	}
	
}