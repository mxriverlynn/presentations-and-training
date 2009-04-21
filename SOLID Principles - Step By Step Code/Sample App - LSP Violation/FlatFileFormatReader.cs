namespace SOLID.SampleApp
{
	class FlatFileFormatReader: IFileFormatReader
	{
		public bool CanHandle(string fileContents)
		{
			return true;
		}

		public string GetMessageBody(string fileContents)
		{
			return fileContents;
		}
	}
}
