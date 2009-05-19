using SimpleOrgChart_CommandPattern.Model;

namespace SimpleOrgChart_CommandPattern.App.NewEmployeeProcess
{
	public class AddNewEmployeeService : IAddNewEmployeeService
	{
		private IGetNewEmployeeInfo GetNewEmployeeInfo { get; set; }
		private IGetEmployeeManager GetEmployeeManager { get; set; }

		public AddNewEmployeeService(IGetNewEmployeeInfo getNewEmployeeInfo, IGetEmployeeManager getEmployeeManager)
		{
			GetNewEmployeeInfo = getNewEmployeeInfo;
			GetEmployeeManager = getEmployeeManager;
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
			}

		}

	}
}