using System;
using System.Windows.Forms;

namespace Simple_Command_Pattern_Example
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			ICommand command = new ACommandImplementation();
			Form1 mainForm = new Form1(command);

			Application.Run(mainForm);
		}
	}
}
