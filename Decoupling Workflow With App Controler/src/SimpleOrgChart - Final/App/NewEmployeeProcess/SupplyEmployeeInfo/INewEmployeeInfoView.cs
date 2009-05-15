namespace SimpleOrgChart___Final.App.NewEmployeeProcess.SupplyEmployeeInfo
{
	public interface INewEmployeeInfoView
	{
		void Run();
		NewEmployeeInfoPresenter Presenter { get; set; }
	}
}