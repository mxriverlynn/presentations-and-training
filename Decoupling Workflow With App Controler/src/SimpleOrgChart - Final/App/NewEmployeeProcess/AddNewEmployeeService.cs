using SimpleOrgChart___Final.AppController;
using SimpleOrgChart___Final.Model;
using SimpleOrgChart___Final.UnitTests;

namespace SimpleOrgChart___Final.App.NewEmployeeProcess
{
	public class AddNewEmployeeService : IAddNewEmployeeService
	{
		private IGetNewEmployeeInfo GetNewEmployeeInfo { get; set; }
		private IGetEmployeeManager GetEmployeeManager { get; set; }
		private IEmployeeRepository EmployeeRepository { get; set; }
		private IApplicationController AppController { get; set; }

		public AddNewEmployeeService(IGetNewEmployeeInfo getNewEmployeeInfo, IGetEmployeeManager getEmployeeManager, IEmployeeRepository employeeRepository, IApplicationController appController)
		{
			GetNewEmployeeInfo = getNewEmployeeInfo;
			GetEmployeeManager = getEmployeeManager;
			EmployeeRepository = employeeRepository;
			AppController = appController;
		}

		public void Run()
		{
			Result<EmployeeInfo> result = GetNewEmployeeInfo.Get();
			if (result.ServiceResult == ServiceResult.Ok)
			{
				EmployeeInfo info = result.Data;
				Employee manager = GetEmployeeManager.Get();
				Employee employee = new Employee(info.FirstName, info.LastName, info.Email);
				employee.Manager = manager;
				EmployeeRepository.Save(employee);
				AppController.Raise(new EmployeeAddedEvent());
			}

		}

	}

}