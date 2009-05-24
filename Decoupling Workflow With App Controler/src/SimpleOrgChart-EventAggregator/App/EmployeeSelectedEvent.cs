using SimpleOrgChart_EventAggregator.Model;

namespace SimpleOrgChart_EventAggregator.App
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