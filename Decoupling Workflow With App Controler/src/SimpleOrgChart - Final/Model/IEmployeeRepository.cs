using System.Collections.Generic;

namespace SimpleOrgChart___Final.Model
{
	public interface IEmployeeRepository
	{
		IList<Employee> GetEmployeeOrgChart();
		IList<Employee> GetManagerList();
	}
}