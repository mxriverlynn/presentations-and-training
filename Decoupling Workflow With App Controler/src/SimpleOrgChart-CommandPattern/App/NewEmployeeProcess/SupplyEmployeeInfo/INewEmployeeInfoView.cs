namespace SimpleOrgChart_CommandPattern.App.NewEmployeeProcess.SupplyEmployeeInfo
{
	public interface INewEmployeeInfoView
	{
		void Run();
		NewEmployeeInfoPresenter Presenter { get; set; }
	}
}