using SimpleOrgChart_CommandPattern.Model;

namespace SimpleOrgChart_CommandPattern.App
{
	public interface IEmployeeDetailPresenter
	{
		void ShowSelectedEmployee(Employee employee);
	}
}