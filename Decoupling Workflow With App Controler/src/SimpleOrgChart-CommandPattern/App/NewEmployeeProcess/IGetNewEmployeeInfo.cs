namespace SimpleOrgChart_CommandPattern.App.NewEmployeeProcess
{
	public interface IGetNewEmployeeInfo
	{
		Result<EmployeeInfo> Get();
	}
}