using System.Collections.Generic;
using SimpleOrgChart___Final.UnitTests;

namespace SimpleOrgChart___Final.App
{
	public interface IOrgChartView
	{
		void DisplayEmployeeHierarchy(IList<Employee> employees);
	}
}