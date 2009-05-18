using System.Collections.Generic;
using SimpleOrgChart_Start.Model;

namespace SimpleOrgChart_Start.App
{
	public interface IOrgChartView
	{
		void DisplayEmployeeHierarchy(IList<Employee> employees);
		OrgChartPresenter Presenter { get; set; }
	}
}