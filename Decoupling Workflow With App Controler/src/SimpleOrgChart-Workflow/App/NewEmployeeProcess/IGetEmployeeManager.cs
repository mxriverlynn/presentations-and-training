using SimpleOrgChart_Workflow.Model;

namespace SimpleOrgChart_Workflow.App.NewEmployeeProcess
{
	public interface IGetEmployeeManager
	{
		Employee GetManagerFor(Employee employee);
	}
}