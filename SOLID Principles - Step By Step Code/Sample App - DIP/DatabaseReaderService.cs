namespace SOLID.SampleApp
{
	public class DatabaseReaderService: IMessageInfoRetriever
	{
	
		private string _connectionString;

		public DatabaseReaderService(string connectionString)
		{
			_connectionString = connectionString;
		}
	
		public string GetMessageBody()
		{
			//pretend you see some database connection going on here. :)
			//SqlConnection conn = new SqlConnection(_connectionString); etc. etc. etc.
			return "pretend this came from a database. :)";			
		}
		
	}
}
