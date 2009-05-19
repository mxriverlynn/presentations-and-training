using SimpleOrgChart_CommandPattern.Model;

namespace SimpleOrgChart_CommandPattern.App.NewEmployeeProcess
{
	public interface IGetEmployeeManager
	{
		Employee GetManagerFor(Employee employee);
	}
}