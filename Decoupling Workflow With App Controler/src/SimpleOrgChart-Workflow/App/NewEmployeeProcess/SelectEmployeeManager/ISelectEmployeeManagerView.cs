using System.Collections.Generic;
using SimpleOrgChart_Workflow.Model;

namespace SimpleOrgChart_Workflow.App.NewEmployeeProcess.SelectEmployeeManager
{
	public interface ISelectEmployeeManagerView
	{
		void ShowListOfManagers(IList<Employee> managerList);
		SelectEmployeeManagerPresenter Presenter { get; set; }
		void ShowEmployee(Employee employee);
		void Run();
	}
}