using System.Windows.Forms;
using SimpleOrgChart_Workflow.App;
using SimpleOrgChart_Workflow.Model;
using SimpleOrgChart_Workflow.Repositories;
using SimpleOrgChart_Workflow.View;

namespace SimpleOrgChart_Workflow
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