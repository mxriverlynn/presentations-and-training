using System.Windows.Forms;
using SimpleOrgChart_EventAggregator.App;
using SimpleOrgChart_EventAggregator.App.NewEmployeeProcess;
using SimpleOrgChart_EventAggregator.Model;
using SimpleOrgChart_EventAggregator.Repositories;
using SimpleOrgChart_EventAggregator.View;

namespace SimpleOrgChart_EventAggregator
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