using System.Windows.Forms;
using SimpleOrgChart_Start.App;
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
			IEmployeeRepository employeeRepository = new InMemoryEmployeeRepository();
			
			MainForm mainForm = new MainForm(employeeRepository);
			IEmployeeDetailPresenter employeeDetailPresenter = new EmployeeDetailPresenter(mainForm.ViewEmployeeDetail);

			OrgChartPresenter presenter = new OrgChartPresenter(mainForm, employeeRepository, employeeDetailPresenter);
			presenter.Run();
			
			return mainForm;
		}

	}

}