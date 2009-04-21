using System;
using System.Xml;

namespace SOLID.SampleApp
{
	public class XmlFormatReader: IFileFormatReader
	{

		XmlDocument _xmlDoc;

		public bool CanHandle(string fileContents)
		{
			bool canHandle;
			try
			{
				_xmlDoc = new XmlDocument();
				_xmlDoc.LoadXml(fileContents);
				canHandle = true;
			}
			catch (Exception)
			{
				canHandle = false;
			}
			return canHandle;
		}

		public string GetMessageBody(string fileContents)
		{
			string messageBody = _xmlDoc.SelectSingleNode("//email/body").InnerText;
			return messageBody;
		}
		
	}
}