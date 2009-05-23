namespace SimpleOrgChart_EventAggregator.App
{

	public interface ICommand<T>
	{
		void Execute(T commandData);
	}

}
