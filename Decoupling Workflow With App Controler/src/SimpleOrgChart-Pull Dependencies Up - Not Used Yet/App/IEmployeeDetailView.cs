namespace SimpleOrgChart_Start.App
{
	public interface IEmployeeDetailView
	{
		void DisplayEmployeeName(string firstName, string lastName);
		void DisplayEmployeeEmail(string email);
	}
}