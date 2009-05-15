using System.Collections.Generic;
using System.Windows.Forms;
using SimpleOrgChart___Final.App;
using SimpleOrgChart___Final.Model;
using StructureMap;

namespace SimpleOrgChart___Final.View
{
	
	public partial class MainForm : Form, IOrgChartView
	{

		public OrgChartPresenter Presenter { get; set; }

		public MainForm(IContainer container)
		{
			InitializeComponent();
			container.Inject<IEmployeeDetailView>(ViewEmployeeDetail);
		}

		public void DisplayEmployeeHierarchy(IList<Employee> employees)
		{
			foreach(Employee employee in employees)
			{
				string displayName = string.Format("{1}, {0}", employee.FirstName, employee.LastName);
				TreeNode node = new TreeNode(displayName);
				node.Tag = employee;
				OrgChart.Nodes.Add(node);
			}
			
		}

		private void OrgChart_AfterSelect(object sender, TreeViewEventArgs e)
		{
			Employee employee = e.Node.Tag as Employee;
			if (employee != null)
				Presenter.EmployeeSelected(employee);
		}

		private void AddNewEmployee_Click(object sender, System.EventArgs e)
		{
			Presenter.AddNewEmployeeRequested();
		}

	}

}