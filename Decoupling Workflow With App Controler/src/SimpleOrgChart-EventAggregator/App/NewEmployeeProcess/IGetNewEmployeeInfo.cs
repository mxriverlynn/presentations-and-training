namespace SimpleOrgChart_EventAggregator.App.NewEmployeeProcess
{
	public interface IGetNewEmployeeInfo
	{
		Result<EmployeeInfo> Get();
	}
}