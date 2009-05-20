using System.Collections.Generic;

namespace SimpleOrgChart_Workflow.Model
{
	public interface IEmployeeRepository
	{
		IList<Employee> GetEmployeeOrgChart();
		IList<Employee> GetManagerList();
	}
}