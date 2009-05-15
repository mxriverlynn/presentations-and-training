using EventAggregator;
using SimpleOrgChart___Final.Model;

namespace SimpleOrgChart___Final.App
{

	public class EmployeeDetailPresenter: IEventHandler<EmployeeSelectedEvent>
	{

		private IEmployeeDetailView View { get; set; }

		public EmployeeDetailPresenter(IEmployeeDetailView view)
		{
			View = view;
		}

		public void Handle(EmployeeSelectedEvent employeeSelectedEvent)
		{
			Employee employee = employeeSelectedEvent.Employee;
			View.DisplayEmployeeName(employee.FirstName, employee.LastName);
			View.DisplayEmployeeEmail(employee.Email);
		}

	}

}