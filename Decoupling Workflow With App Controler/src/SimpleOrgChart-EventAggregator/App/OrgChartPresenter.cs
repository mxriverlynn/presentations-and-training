using System.Collections.Generic;
using EventAggregator;
using SimpleOrgChart_EventAggregator.App.NewEmployeeProcess;
using SimpleOrgChart_EventAggregator.Model;

namespace SimpleOrgChart_EventAggregator.App
{
	public class OrgChartPresenter
	{

		private IOrgChartView View { get; set; }
		private ICommand<AddNewEmployeeData> AddNewEmployeeCommand { get; set; }
		private IEmployeeRepository Repository { get; set; }
		private IEventPublisher EventPublisher { get; set; }

		public OrgChartPresenter(IOrgChartView view, IEmployeeRepository repository, IEventPublisher eventPublisher, ICommand<AddNewEmployeeData> addNewEmployeeCommand)
		{
			View = view;
			AddNewEmployeeCommand = addNewEmployeeCommand;
			View.Presenter = this;
			Repository = repository;
			EventPublisher = eventPublisher;
		}

		public void AddNewEmployeeRequested()
		{
			AddNewEmployeeCommand.Execute(new AddNewEmployeeData());
			ShowEmployeeHierarchy();
		}

		public void EmployeeSelected(Employee selectedEmployee)
		{
			EventPublisher.Publish(new EmployeeSelectedEvent(selectedEmployee));
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