using EventAggregator;
using SimpleOrgChart_EventAggregator.Model;

namespace SimpleOrgChart_EventAggregator.App
{
	public class EmployeeDetailPresenter: IEventHandler<EmployeeSelectedEvent>
	{

		private IEmployeeDetailView View { get; set; }

		public EmployeeDetailPresenter(IEmployeeDetailView view)
		{
			View = view;
		}

		public void Handle(EmployeeSelectedEvent eventData)
		{
			Employee employee = eventData.Employee;
			View.DisplayEmployeeName(employee.FirstName, employee.LastName);
			View.DisplayEmployeeEmail(employee.Email);
		}

	}
}
