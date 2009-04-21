using System;
using System.Windows.Forms;

namespace SOLID.SampleApp
{

	public partial class Form1 : Form
	{
	
		private string _fileName;

		public Form1()
		{
			InitializeComponent();
		}

		private void Send_Click(object sender, EventArgs e)
		{
			try
			{
				Output.Text = string.Empty;

				FileReaderService fileReaderService = new FileReaderService(_fileName);
				fileReaderService.RegisterFormatReader(new XmlFormatReader());
				fileReaderService.RegisterDefaultFormatReader(new FlatFileFormatReader());

				ProcessingService processingService = new ProcessingService(new EmailSender(), fileReaderService); 
				string messageSendingStatus = processingService.SendMessage();

				Output.Text = messageSendingStatus;
			}
			catch (Exception ex)
			{
				Output.Text = ex.ToString();
			}
		}

		private void SendFromDatabase_Click(object sender, EventArgs e)
		{
			try
			{
				Output.Text = string.Empty;
			
				IMessageInfoRetriever databaseReaderService = new DatabaseReaderService("server=foo; database=bar;");
				
				ProcessingService processingService = new ProcessingService(new EmailSender(), databaseReaderService); 
				string messageSendingStatus = processingService.SendMessage();

				Output.Text = messageSendingStatus;
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
				dlg.Filter = "Text Files (*.txt)|*.txt|XML Files (*.xml)|*.xml";
				if (dlg.ShowDialog() == DialogResult.OK)
				{
					_fileName = dlg.FileName;
					SelectedFile.Text = _fileName;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}
	}
	
}