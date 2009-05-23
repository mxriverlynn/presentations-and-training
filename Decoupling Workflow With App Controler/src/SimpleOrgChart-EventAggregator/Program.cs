using System;
using System.Windows.Forms;

namespace SimpleOrgChart_EventAggregator
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
