namespace SOLID.SampleApp
{
	public interface IFileFormatReader
	{
		bool CanHandle(string fileContents);
		string GetMessageBody(string fileContents);
	}
}