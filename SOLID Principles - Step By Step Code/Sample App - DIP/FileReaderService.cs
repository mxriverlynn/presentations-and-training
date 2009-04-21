using System.Collections.Generic;
using System.IO;

namespace SOLID.SampleApp
{
	public class FileReaderService : IMessageInfoRetriever
	{
		private readonly Queue<IFileFormatReader> formatReaders = new Queue<IFileFormatReader>();
		private IFileFormatReader _defaultFormatReader;
		private readonly string _fileName;

		public FileReaderService(string fileName)
		{
			_fileName = fileName;
		}

		public string GetMessageBody()
		{
			string fileContents = GetFileContents(_fileName);
			string messageBody = ParseFileContents(fileContents);
			return messageBody; 
		}

		public void RegisterDefaultFormatReader(IFileFormatReader defaultFormatReader)
		{
			_defaultFormatReader = defaultFormatReader;
		}

		public void RegisterFormatReader(IFileFormatReader fileFormatReader)
		{
			formatReaders.Enqueue(fileFormatReader);
		}

		private string ParseFileContents(string fileContents)
		{
			string messageBody = string.Empty;
			bool wasHandled = false;

			foreach (IFileFormatReader formatReader in formatReaders)
			{
				if (formatReader.CanHandle(fileContents))
				{
					messageBody = formatReader.GetMessageBody(fileContents);
					wasHandled = true;
				}
			}

			if (!wasHandled)
			{
				messageBody = _defaultFormatReader.GetMessageBody(fileContents);
			}

			return messageBody;
		}

		private string GetFileContents(string fileName)
		{
			FileInfo file = new FileInfo(fileName);
			StreamReader rdr = file.OpenText();
			string fileContents = rdr.ReadToEnd();
			rdr.Dispose();
			return fileContents;
		}
		
	}
}
