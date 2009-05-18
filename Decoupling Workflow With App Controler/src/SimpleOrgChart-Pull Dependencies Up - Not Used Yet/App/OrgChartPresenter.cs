using System.Collections.Generic;
using SimpleOrgChart_Start.App.NewEmployeeProcess;
using SimpleOrgChart_Start.Model;

namespace SimpleOrgChart_Start.App
{
	public class OrgChartPresenter
	{

		private IOrgChartView View { get; set; }
		private IEmployeeDetailPresenter EmployeeDetailPresenter { get; set; }
		private IAddNewEmployeeService AddNewEmployeeService { get; set; }
		private IEmployeeRepository Repository { get; set; }

		public OrgChartPresenter(IOrgChartView view, IEmployeeRepository repository, IEmployeeDetailPresenter employeeDetailPresenter, IAddNewEmployeeService addNewEmployeeService)
		{
			View = view;
			EmployeeDetailPresenter = employeeDetailPresenter;
			AddNewEmployeeService = addNewEmployeeService;
			View.Presenter = this;
			Repository = repository;
		}

		public void Run()
		{
			ShowEmployeeHierarchy();
		}

		public void EmployeeSelected(Employee selectedEmployee)
		{
			EmployeeDetailPresenter.ShowSelectedEmployee(selectedEmployee);
		}

		public void AddNewEmployeeRequested()
		{
			AddNewEmployeeService.Run();
			ShowEmployeeHierarchy();
		}

		private void ShowEmployeeHierarchy()
		{
			IList<Employee> employeeList = Repository.GetEmployeeOrgChart();
			View.DisplayEmployeeHierarchy(employeeList);
		}

	}
}