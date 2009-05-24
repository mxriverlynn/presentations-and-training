using EventAggregator;
using SimpleOrgChart_EventAggregator.Model;

namespace SimpleOrgChart_EventAggregator.App.NewEmployeeProcess
{
	public class AddNewEmployeeService : IAddNewEmployeeService
	{
		private IGetNewEmployeeInfo GetNewEmployeeInfo { get; set; }
		private IGetEmployeeManager GetEmployeeManager { get; set; }
		private IEventPublisher EventPublisher { get; set; }

		public AddNewEmployeeService(IGetNewEmployeeInfo getNewEmployeeInfo, IGetEmployeeManager getEmployeeManager, IEventPublisher eventPublisher)
		{
			GetNewEmployeeInfo = getNewEmployeeInfo;
			GetEmployeeManager = getEmployeeManager;
			EventPublisher = eventPublisher;
		}

		public void Run()
		{
			Result<EmployeeInfo> result = GetNewEmployeeInfo.Get();
			if (result.ServiceResult == ServiceResult.Ok)
			{
				EmployeeInfo info = result.Data;
				Employee employee = new Employee(info.FirstName, info.LastName, info.Email);

				Employee manager = GetEmployeeManager.GetManagerFor(employee);
				manager.Employees.Add(employee);

				EventPublisher.Publish(new EmployeeAddedEvent());
			}

		}

	}
}