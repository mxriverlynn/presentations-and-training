using SimpleOrgChart_CommandPattern.App.NewEmployeeProcess.SelectEmployeeManager;
using SimpleOrgChart_CommandPattern.App.NewEmployeeProcess.SupplyEmployeeInfo;
using SimpleOrgChart_CommandPattern.Model;
using SimpleOrgChart_CommandPattern.View;

namespace SimpleOrgChart_CommandPattern.App.NewEmployeeProcess
{

	public class AddNewEmployeeCommand: ICommand<AddNewEmployeeData>
	{

		private IEmployeeRepository EmployeeRepository { get; set; }

		public AddNewEmployeeCommand(IEmployeeRepository employeeRepository)
		{
			EmployeeRepository = employeeRepository;
		}

		public void Execute(AddNewEmployeeData data)
		{
			NewEmployeeInfoForm newEmployeeInfoForm = new NewEmployeeInfoForm();
			NewEmployeeInfoPresenter newEmployeeInfoPresenter = new NewEmployeeInfoPresenter(newEmployeeInfoForm);

			SelectEmployeeManagerForm selectEmployeeManagerForm = new SelectEmployeeManagerForm();
			SelectEmployeeManagerPresenter selectEmployeeManagerPresenter = new SelectEmployeeManagerPresenter(selectEmployeeManagerForm, EmployeeRepository);

			IAddNewEmployeeService addNewEmployeeService = new AddNewEmployeeService(newEmployeeInfoPresenter, selectEmployeeManagerPresenter);
			addNewEmployeeService.Run();
		}

	}

}
