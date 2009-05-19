using System;
using System.Windows.Forms;
using SimpleOrgChart_Start;

namespace SimpleOrgChart_CommandPattern
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

			ApplicationContext appcontext = new AppContext();
			Application.Run(appcontext);
		}
	}
}
