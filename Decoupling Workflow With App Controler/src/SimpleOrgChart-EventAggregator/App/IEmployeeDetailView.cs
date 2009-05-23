namespace SimpleOrgChart_EventAggregator.App
{
	public interface IEmployeeDetailView
	{
		void DisplayEmployeeName(string firstName, string lastName);
		void DisplayEmployeeEmail(string email);
	}
}