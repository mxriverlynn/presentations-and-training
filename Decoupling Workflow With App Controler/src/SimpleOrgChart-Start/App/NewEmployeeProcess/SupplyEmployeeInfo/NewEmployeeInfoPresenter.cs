using SimpleOrgChart_Start.Model;

namespace SimpleOrgChart_Start.App.NewEmployeeProcess.SupplyEmployeeInfo
{
	public class NewEmployeeInfoPresenter : IGetNewEmployeeInfo
	{
		private INewEmployeeInfoView View { get; set; }
		private IGetEmployeeManager GetEmployeeManager { get; set; }
		private string LastName { get; set; }
		private string FirstName { get; set; }
		private string Email { get; set; }
		private ServiceResult ServiceResult { get; set; }

		public NewEmployeeInfoPresenter(INewEmployeeInfoView view, IGetEmployeeManager getEmployeeManager)
		{
			View = view;
			View.Presenter = this;
			GetEmployeeManager = getEmployeeManager;
		}

		public void Run()
		{
			View.Run();
			Employee employee = new Employee(FirstName, LastName, Email);
			if (ServiceResult == ServiceResult.Ok)
			{
				Employee manager = GetEmployeeManager.GetManagerFor(employee);
				manager.Employees.Add(employee);
			}
		}

		public void FirstNameSupplied(string firstname)
		{
			FirstName = firstname;
		}

		public void LastNameSupplied(string lastname)
		{
			LastName = lastname;
		}

		public void EmailSupplied(string email)
		{
			Email = email;
		}

		public void Next()
		{
			ServiceResult = ServiceResult.Ok;
		}

		public void Cancel()
		{
			ServiceResult = ServiceResult.Cancel;
		}

	}

}
