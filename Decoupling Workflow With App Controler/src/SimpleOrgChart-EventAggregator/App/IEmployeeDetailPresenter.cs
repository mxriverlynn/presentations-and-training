using SimpleOrgChart_EventAggregator.Model;

namespace SimpleOrgChart_EventAggregator.App
{
	public interface IEmployeeDetailPresenter
	{
		void ShowSelectedEmployee(Employee employee);
	}
}