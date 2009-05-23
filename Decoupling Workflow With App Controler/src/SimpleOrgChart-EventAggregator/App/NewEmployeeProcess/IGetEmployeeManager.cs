using SimpleOrgChart_EventAggregator.Model;

namespace SimpleOrgChart_EventAggregator.App.NewEmployeeProcess
{
	public interface IGetEmployeeManager
	{
		Employee GetManagerFor(Employee employee);
	}
}