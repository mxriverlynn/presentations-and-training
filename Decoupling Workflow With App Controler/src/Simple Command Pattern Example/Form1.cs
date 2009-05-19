using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Simple_Command_Pattern_Example
{
	
	public partial class Form1 : Form
	{
		protected ICommand SomeCommand { get; set; }

		public Form1(ICommand someCommand)
		{
			InitializeComponent();
			SomeCommand = someCommand;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			SomeCommand.Execute();
		}

	}
}
