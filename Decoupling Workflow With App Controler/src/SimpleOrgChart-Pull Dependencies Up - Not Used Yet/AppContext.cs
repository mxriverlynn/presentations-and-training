using System.Windows.Forms;
using SimpleOrgChart_Start.App;
using SimpleOrgChart_Start.App.NewEmployeeProcess;
using SimpleOrgChart_Start.App.NewEmployeeProcess.SelectEmployeeManager;
using SimpleOrgChart_Start.App.NewEmployeeProcess.SupplyEmployeeInfo;
using SimpleOrgChart_Start.Model;
using SimpleOrgChart_Start.Repositories;
using SimpleOrgChart_Start.View;

namespace SimpleOrgChart_Start
{

	public class AppContext : ApplicationContext
	{
		
		public AppContext()
		{
			MainForm = GetMainForm();
		}

		private Form GetMainForm()
		{
			MainForm mainForm = new MainForm();
			IEmployeeDetailPresenter employeeDetailPresenter = new EmployeeDetailPresenter(mainForm.ViewEmployeeDetail);

			NewEmployeeInfoForm newEmployeeInfoForm = new NewEmployeeInfoForm();
			IGetNewEmployeeInfo getNewEmployeeInfo = new NewEmployeeInfoPresenter(newEmployeeInfoForm);

			IEmployeeRepository employeeRepository = new InMemoryEmployeeRepository();
			
			SelectEmployeeManagerForm selectEmployeeManagerForm = new SelectEmployeeManagerForm();
			IGetEmployeeManager getEmployeeManager = new SelectEmployeeManagerPresenter(selectEmployeeManagerForm, employeeRepository);
			
			IAddNewEmployeeService addNewEmployeeService = new AddNewEmployeeService(getNewEmployeeInfo, getEmployeeManager);

			OrgChartPresenter presenter = new OrgChartPresenter(mainForm, employeeRepository, employeeDetailPresenter, addNewEmployeeService);
			presenter.Run();
			
			return mainForm;
		}

	}

}