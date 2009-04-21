using System;
using System.Xml;

namespace SOLID.SampleApp
{
	public class FormatReader
	{
		public string GetMessageBody(string fileContents)
		{
			string messageBody;
			try
			{
				XmlDocument xmlDoc = new XmlDocument();
				xmlDoc.LoadXml(fileContents);
				messageBody = xmlDoc.SelectSingleNode("//email/body").InnerText;
			}
			catch (Exception)
			{
				messageBody = fileContents;
			}
			return messageBody;
		}
	}
}
