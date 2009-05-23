using SimpleOrgChart_EventAggregator.App.NewEmployeeProcess.SelectEmployeeManager;
using SimpleOrgChart_EventAggregator.App.NewEmployeeProcess.SupplyEmployeeInfo;
using SimpleOrgChart_EventAggregator.Model;
using SimpleOrgChart_EventAggregator.View;

namespace SimpleOrgChart_EventAggregator.App.NewEmployeeProcess
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
