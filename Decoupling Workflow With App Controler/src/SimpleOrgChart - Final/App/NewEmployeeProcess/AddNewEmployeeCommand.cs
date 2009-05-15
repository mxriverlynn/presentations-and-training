using SimpleOrgChart___Final.AppController;

namespace SimpleOrgChart___Final.App.NewEmployeeProcess
{
	public class AddNewEmployeeCommand: ICommand<AddNewEmployeeData>
	{
		private IAddNewEmployeeService AddNewEmployeeService { get; set; }

		public AddNewEmployeeCommand(IAddNewEmployeeService addNewEmployeeService)
		{
			AddNewEmployeeService = addNewEmployeeService;
		}

		public void Execute(AddNewEmployeeData commandData)
		{
			AddNewEmployeeService.Run();
		}
	}
}