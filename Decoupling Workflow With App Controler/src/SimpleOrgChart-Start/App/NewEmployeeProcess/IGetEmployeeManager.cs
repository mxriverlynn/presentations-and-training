using SimpleOrgChart_Start.Model;

namespace SimpleOrgChart_Start.App.NewEmployeeProcess
{
	public interface IGetEmployeeManager
	{
		Employee GetManagerFor(Employee employee);
	}
}