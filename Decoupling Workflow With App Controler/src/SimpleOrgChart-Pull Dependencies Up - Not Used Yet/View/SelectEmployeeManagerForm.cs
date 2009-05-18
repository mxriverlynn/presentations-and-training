using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SimpleOrgChart_Start.App.NewEmployeeProcess.SelectEmployeeManager;
using SimpleOrgChart_Start.Model;

namespace SimpleOrgChart_Start.View
{
	public partial class SelectEmployeeManagerForm : Form, ISelectEmployeeManagerView
	{

		public SelectEmployeeManagerPresenter Presenter { get; set; }

		public SelectEmployeeManagerForm()
		{
			InitializeComponent();
		}

		private void ManagerList_SelectedIndexChanged(object sender, EventArgs e)
		{
			Employee manager = ManagerList.SelectedItem as Employee;
			Presenter.ManagerSelected(manager);
		}

		private void Done_Click(object sender, EventArgs e)
		{
			Close();
		}

		public void ShowListOfManagers(IList<Employee> managerList)
		{
			ManagerList.DisplayMember = "DisplayName";
			ManagerList.DataSource = managerList;
		}

		public void ShowEmployee(Employee employee)
		{
			Employee.Text = employee.DisplayName;
		}

		public void Run()
		{
			ShowDialog();
		}

	}
}