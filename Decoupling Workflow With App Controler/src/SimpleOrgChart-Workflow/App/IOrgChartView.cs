using System.Collections.Generic;
using SimpleOrgChart_Workflow.Model;

namespace SimpleOrgChart_Workflow.App
{
	public interface IOrgChartView
	{
		void DisplayEmployeeHierarchy(IList<Employee> employees);
		OrgChartPresenter Presenter { get; set; }
	}
}