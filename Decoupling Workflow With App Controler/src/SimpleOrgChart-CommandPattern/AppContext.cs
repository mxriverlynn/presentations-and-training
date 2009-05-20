using System.Windows.Forms;
using SimpleOrgChart_CommandPattern.App;
using SimpleOrgChart_CommandPattern.App.NewEmployeeProcess;
using SimpleOrgChart_CommandPattern.Model;
using SimpleOrgChart_CommandPattern.Repositories;
using SimpleOrgChart_CommandPattern.View;

namespace SimpleOrgChart_CommandPattern
{
	public class AppContext : ApplicationContext
	{
		
		public AppContext()
		{
			MainForm = GetMainForm();
		}

		private Form GetMainForm()
		{
			IEmployeeRepository employeeRepository = new InMemoryEmployeeRepository();
			
			MainForm mainForm = new MainForm();
			IEmployeeDetailPresenter employeeDetailPresenter = new EmployeeDetailPresenter(mainForm.ViewEmployeeDetail);
			ICommand<AddNewEmployeeData> addNewEmployeeCommand = new AddNewEmployeeCommand(employeeRepository);

			OrgChartPresenter presenter = new OrgChartPresenter(mainForm, employeeRepository, employeeDetailPresenter, addNewEmployeeCommand);
			presenter.Run();
			
			return mainForm;
		}

	}
}