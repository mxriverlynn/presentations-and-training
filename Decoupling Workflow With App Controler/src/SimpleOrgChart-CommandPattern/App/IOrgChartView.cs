using System.Collections.Generic;
using SimpleOrgChart_CommandPattern.Model;

namespace SimpleOrgChart_CommandPattern.App
{
	public interface IOrgChartView
	{
		void DisplayEmployeeHierarchy(IList<Employee> employees);
		OrgChartPresenter Presenter { get; set; }
	}
}