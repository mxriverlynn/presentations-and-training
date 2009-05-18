using SimpleOrgChart_Start.Model;

namespace SimpleOrgChart_Start.App
{
	public class EmployeeDetailPresenter: IEmployeeDetailPresenter
	{

		private IEmployeeDetailView View { get; set; }

		public EmployeeDetailPresenter(IEmployeeDetailView view)
		{
			View = view;
		}

		public void ShowSelectedEmployee(Employee employee)
		{
			View.DisplayEmployeeName(employee.FirstName, employee.LastName);
			View.DisplayEmployeeEmail(employee.Email);
		}

	}
}