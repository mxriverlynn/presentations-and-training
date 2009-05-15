using SimpleOrgChart___Final.Model;

namespace SimpleOrgChart___Final.App
{
	public class EmployeeSelectedEvent
	{
		public Employee Employee { get; private set; }

		public EmployeeSelectedEvent(Employee employee)
		{
			Employee = employee;
		}
	}
}