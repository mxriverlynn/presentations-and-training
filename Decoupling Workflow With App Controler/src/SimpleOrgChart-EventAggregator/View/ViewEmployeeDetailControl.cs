using System.Windows.Forms;
using SimpleOrgChart_EventAggregator.App;

namespace SimpleOrgChart_EventAggregator.View
{
	public partial class ViewEmployeeDetailControl : UserControl, IEmployeeDetailView
	{
		public ViewEmployeeDetailControl()
		{
			InitializeComponent();
		}

		public void DisplayEmployeeName(string firstName, string lastName)
		{
			EmployeeName.Text = string.Format("{1}, {0}", firstName, lastName);
		}

		public void DisplayEmployeeEmail(string email)
		{
			Email.Text = email;
		}
	}
}