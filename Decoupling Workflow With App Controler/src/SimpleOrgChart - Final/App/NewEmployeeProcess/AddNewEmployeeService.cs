using SimpleOrgChart___Final.AppController;
using SimpleOrgChart___Final.Model;
using SimpleOrgChart___Final.UnitTests;

namespace SimpleOrgChart___Final.App.NewEmployeeProcess
{
	public class AddNewEmployeeService : IAddNewEmployeeService
	{
		private IGetNewEmployeeInfo GetNewEmployeeInfo { get; set; }
		private IGetEmployeeManager GetEmployeeManager { get; set; }
		private IApplicationController AppController { get; set; }

		public AddNewEmployeeService(IGetNewEmployeeInfo getNewEmployeeInfo, IGetEmployeeManager getEmployeeManager, IApplicationController appController)
		{
			GetNewEmployeeInfo = getNewEmployeeInfo;
			GetEmployeeManager = getEmployeeManager;
			AppController = appController;
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
				
				AppController.Raise(new EmployeeAddedEvent());
			}

		}

	}

}