using System.Collections.Generic;
using SimpleOrgChart___Final.Model;

namespace SimpleOrgChart___Final.App.NewEmployeeProcess.SelectEmployeeManager
{
	public interface ISelectEmployeeManagerView
	{
		void ShowListOfManagers(IList<Employee> managerList);
		SelectEmployeeManagerPresenter Presenter { get; set; }
		void ShowEmployee(Employee employee);
		void Run();
	}
}