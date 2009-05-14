using System.Windows.Forms;
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
			MainForm mainForm = new MainForm();
			//Container.Inject<IMainView>(mainForm);
			//Container.GetInstance<MainPresenter>();
			return mainForm;
		}

	}
}