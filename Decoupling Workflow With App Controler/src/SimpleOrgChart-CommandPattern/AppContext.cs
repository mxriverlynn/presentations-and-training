using System.Windows.Forms;
using SimpleOrgChart_CommandPattern.App;
using SimpleOrgChart_CommandPattern.Model;
using SimpleOrgChart_CommandPattern.Repositories;
using SimpleOrgChart_CommandPattern.View;

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
			IEmployeeRepository employeeRepository = new InMemoryEmployeeRepository();
			
			MainForm mainForm = new MainForm(employeeRepository);
			IEmployeeDetailPresenter employeeDetailPresenter = new EmployeeDetailPresenter(mainForm.ViewEmployeeDetail);

			OrgChartPresenter presenter = new OrgChartPresenter(mainForm, employeeRepository, employeeDetailPresenter);
			presenter.Run();
			
			return mainForm;
		}

	}

}