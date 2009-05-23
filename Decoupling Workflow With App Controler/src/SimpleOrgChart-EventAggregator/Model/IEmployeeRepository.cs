using System.Collections.Generic;

namespace SimpleOrgChart_EventAggregator.Model
{
	public interface IEmployeeRepository
	{
		IList<Employee> GetEmployeeOrgChart();
		IList<Employee> GetManagerList();
	}
}