using System.Windows.Forms;
using EventAggregator;
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

			IEventPublisher eventPublisher = new EventPublisher();
			
			MainForm mainForm = new MainForm();
			EmployeeDetailPresenter employeeDetailPresenter = new EmployeeDetailPresenter(mainForm.ViewEmployeeDetail);
			eventPublisher.RegisterHandlers(employeeDetailPresenter);

			ICommand<AddNewEmployeeData> addNewEmployeeCommand = new AddNewEmployeeCommand(employeeRepository, eventPublisher);

			OrgChartPresenter presenter = new OrgChartPresenter(mainForm, employeeRepository, eventPublisher, addNewEmployeeCommand);
			eventPublisher.RegisterHandlers(presenter);
			presenter.Run();
			
			return mainForm;
		}

	}
}