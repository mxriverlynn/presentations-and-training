using System.Collections.Generic;
using SimpleOrgChart_Start.Model;

namespace SimpleOrgChart_Start.App.NewEmployeeProcess.SelectEmployeeManager
{
	public interface ISelectEmployeeManagerView
	{
		void ShowListOfManagers(IList<Employee> managerList);
		SelectEmployeeManagerPresenter Presenter { get; set; }
		void ShowEmployee(Employee employee);
		void Run();
	}
}