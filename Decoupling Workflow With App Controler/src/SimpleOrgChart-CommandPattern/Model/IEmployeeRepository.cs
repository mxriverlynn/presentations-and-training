using System.Collections.Generic;

namespace SimpleOrgChart_CommandPattern.Model
{
	public interface IEmployeeRepository
	{
		IList<Employee> GetEmployeeOrgChart();
		IList<Employee> GetManagerList();
	}
}