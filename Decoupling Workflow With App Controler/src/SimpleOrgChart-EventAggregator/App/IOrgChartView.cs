using System.Collections.Generic;
using SimpleOrgChart_EventAggregator.Model;

namespace SimpleOrgChart_EventAggregator.App
{
	public interface IOrgChartView
	{
		void DisplayEmployeeHierarchy(IList<Employee> employees);
		OrgChartPresenter Presenter { get; set; }
	}
}