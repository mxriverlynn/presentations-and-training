namespace SimpleOrgChart_CommandPattern.App
{

	public interface ICommand<T>
	{
		void Execute(T commandData);
	}

}
