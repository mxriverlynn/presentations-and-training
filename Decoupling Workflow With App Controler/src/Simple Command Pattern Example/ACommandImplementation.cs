namespace Simple_Command_Pattern_Example
{
	public class ACommandImplementation: ICommand
	{
		public void Execute()
		{
			AMessageForYou aMessage = new AMessageForYou();
			aMessage.Show();
		}
	}
}