using System.Collections.Generic;
using SimpleOrgChart_EventAggregator.Model;

namespace SimpleOrgChart_EventAggregator.App.NewEmployeeProcess.SelectEmployeeManager
{
	public interface ISelectEmployeeManagerView
	{
		void ShowListOfManagers(IList<Employee> managerList);
		SelectEmployeeManagerPresenter Presenter { get; set; }
		void ShowEmployee(Employee employee);
		void Run();
	}
}