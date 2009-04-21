using System;

namespace SOLID.SampleApp
{
	public class DatabaseConnectionReader : IFileFormatReader
	{
	
		public bool CanHandle(string fileContents)
		{
			bool canHandle = false;
			if (fileContents.StartsWith("file="))
				canHandle = true;
			return canHandle;
		}

		public string GetMessageBody(string fileContents)
		{
			throw new NotImplementedException("Need to read from the database! Not from this interface!");
		}
		
	}
}