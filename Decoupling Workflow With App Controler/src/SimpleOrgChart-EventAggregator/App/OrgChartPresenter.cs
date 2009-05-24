using System.Collections.Generic;
using EventAggregator;
using SimpleOrgChart_EventAggregator.App.NewEmployeeProcess;
using SimpleOrgChart_EventAggregator.Model;

namespace SimpleOrgChart_EventAggregator.App
{
	public class OrgChartPresenter: IEventHandler<EmployeeAddedEvent>
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
		}

		public void EmployeeSelected(Employee selectedEmployee)
		{
			EventPublisher.Publish(new EmployeeSelectedEvent(selectedEmployee));
		}

		public void Run()
		{
			ShowEmployeeHierarchy();
		}

		public void Handle(EmployeeAddedEvent eventData)
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