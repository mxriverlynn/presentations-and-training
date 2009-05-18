using System.Collections.Generic;
using SimpleOrgChart_Start.App.NewEmployeeProcess;
using SimpleOrgChart_Start.Model;

namespace SimpleOrgChart_Start.App
{
	public class OrgChartPresenter
	{

		private IOrgChartView View { get; set; }
		private IEmployeeDetailPresenter EmployeeDetailPresenter { get; set; }
		private IEmployeeRepository Repository { get; set; }

		public OrgChartPresenter(IOrgChartView view, IEmployeeRepository repository, IEmployeeDetailPresenter employeeDetailPresenter)
		{
			View = view;
			EmployeeDetailPresenter = employeeDetailPresenter;
			View.Presenter = this;
			Repository = repository;
		}

		public void EmployeeSelected(Employee selectedEmployee)
		{
			EmployeeDetailPresenter.ShowSelectedEmployee(selectedEmployee);
		}

		public void Run()
		{
			ShowEmployeeHierarchy();
		}

		public void AddNewEmployeeRequested(IAddNewEmployeeService addnewEmployeeService)
		{
			addnewEmployeeService.Run();
			ShowEmployeeHierarchy();
		}

		private void ShowEmployeeHierarchy()
		{
			IList<Employee> employeeList = Repository.GetEmployeeOrgChart();
			View.DisplayEmployeeHierarchy(employeeList);
		}

	}
}