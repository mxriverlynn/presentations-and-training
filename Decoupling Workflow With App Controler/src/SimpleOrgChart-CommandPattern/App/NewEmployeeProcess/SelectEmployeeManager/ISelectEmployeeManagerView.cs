using System.Collections.Generic;
using SimpleOrgChart_CommandPattern.Model;

namespace SimpleOrgChart_CommandPattern.App.NewEmployeeProcess.SelectEmployeeManager
{
	public interface ISelectEmployeeManagerView
	{
		void ShowListOfManagers(IList<Employee> managerList);
		SelectEmployeeManagerPresenter Presenter { get; set; }
		void ShowEmployee(Employee employee);
		void Run();
	}
}