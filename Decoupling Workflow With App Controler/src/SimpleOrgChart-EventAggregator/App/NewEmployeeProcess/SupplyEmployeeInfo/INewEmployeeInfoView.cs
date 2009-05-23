namespace SimpleOrgChart_EventAggregator.App.NewEmployeeProcess.SupplyEmployeeInfo
{
	public interface INewEmployeeInfoView
	{
		void Run();
		NewEmployeeInfoPresenter Presenter { get; set; }
	}
}