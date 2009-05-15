using SimpleOrgChart___Final.Model;

namespace SimpleOrgChart___Final.App.NewEmployeeProcess
{
	public interface IGetEmployeeManager
	{
		Employee GetManagerFor(Employee employee);
	}
}