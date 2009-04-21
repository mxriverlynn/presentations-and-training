using System.Collections.Generic;

namespace SOLID.SampleApp
{
	public class FileReaderService
	{

		private readonly IList<IFileFormatReader> _formatReaders = new List<IFileFormatReader>();
		private IFileFormatReader _defaultFormatReader;

		public string GetMessageBody(string fileContents)
		{
			string messageBody = string.Empty;
			bool wasHandled = false;

			foreach (IFileFormatReader formatReader in _formatReaders)
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

		public void RegisterDefaultFormatReader(IFileFormatReader defaultFormatReader)
		{
			_defaultFormatReader = defaultFormatReader;
		}

		public void RegisterFormatReader(IFileFormatReader fileFormatReader)
		{
			_formatReaders.Add(fileFormatReader);
		}

	}
}
