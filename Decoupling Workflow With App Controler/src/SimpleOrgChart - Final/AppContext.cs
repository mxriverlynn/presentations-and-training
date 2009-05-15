using System.Windows.Forms;
using SimpleOrgChart___Final.App;
using SimpleOrgChart___Final.View;
using StructureMap;

namespace SimpleOrgChart___Final
{
	public class AppContext : ApplicationContext
	{
		
		private IContainer Container { get; set; }

		public AppContext(IContainer container)
		{
			Container = container;
			MainForm = GetMainForm();
		}

		private Form GetMainForm()
		{
			MainForm mainForm = new MainForm(Container);
			Container.Inject<IOrgChartView>(mainForm);
			
			OrgChartPresenter presenter = Container.GetInstance<OrgChartPresenter>();
			presenter.Run();
			
			return mainForm;
		}

	}
}