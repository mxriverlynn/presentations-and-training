using System.Collections.Generic;
using SimpleOrgChart_EventAggregator.App.NewEmployeeProcess;
using SimpleOrgChart_EventAggregator.Model;

namespace SimpleOrgChart_EventAggregator.App
{
	public class OrgChartPresenter
	{

		private IOrgChartView View { get; set; }
		private IEmployeeDetailPresenter EmployeeDetailPresenter { get; set; }
		private ICommand<AddNewEmployeeData> AddNewEmployeeCommand { get; set; }
		private IEmployeeRepository Repository { get; set; }

		public OrgChartPresenter(IOrgChartView view, IEmployeeRepository repository, IEmployeeDetailPresenter employeeDetailPresenter, ICommand<AddNewEmployeeData> addNewEmployeeCommand)
		{
			View = view;
			EmployeeDetailPresenter = employeeDetailPresenter;
			AddNewEmployeeCommand = addNewEmployeeCommand;
			View.Presenter = this;
			Repository = repository;
		}

		public void AddNewEmployeeRequested()
		{
			AddNewEmployeeCommand.Execute(new AddNewEmployeeData());
			ShowEmployeeHierarchy();
		}

		public void EmployeeSelected(Employee selectedEmployee)
		{
			EmployeeDetailPresenter.ShowSelectedEmployee(selectedEmployee);
		}

		public void Run()
		{
			ShowEmployeeHierarchy();
		}

		private void ShowEmployeeHierarchy()
		{
			IList<Employee> employeeList = Repository.GetEmployeeOrgChart();
			View.DisplayEmployeeHierarchy(employeeList);
		}

	}
}