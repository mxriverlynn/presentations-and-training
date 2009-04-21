using System;
using System.Windows.Forms;

namespace SOLID.SampleApp
{

	public partial class Form1 : Form
	{
	
		private readonly EmailSender _emailSender = new EmailSender();

		public Form1()
		{
			InitializeComponent();
		}

		private void Send_Click(object sender, EventArgs e)
		{
			try
			{
				Output.Text = string.Empty;

				_emailSender.ReadFile();
				_emailSender.SendEmail();

				Output.Text = "Sent email with body: " + Environment.NewLine + _emailSender.MessageBody;
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
				dlg.Filter = "Text Files (*.txt)|*.txt|XML Files(*.xml)|*.xml";
				if (dlg.ShowDialog() == DialogResult.OK)
				{
					_emailSender.FileName = dlg.FileName;
					SelectedFile.Text = _emailSender.FileName;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

	}
	
}