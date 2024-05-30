using System;
using Infrastructure;
using System.Windows.Forms;

namespace MyApplication;

internal static class Program
{
	[STAThread]
	private static void Main()
	{
		ApplicationConfiguration.Initialize();

		// **************************************************
		//Application.Run(mainForm: new LoginForm());
		// **************************************************

		// **************************************************
		//var mainForm = new LoginForm();

		//Application.Run(mainForm: mainForm);

		//if (mainForm != null)
		//{
		//	if (mainForm.IsDisposed == false)
		//	{
		//		mainForm.Dispose();
		//	}

		//	//mainForm = null;
		//}
		// **************************************************

		// **************************************************
		Application.Run(mainForm: Utility.LoginForm);

		Utility.DisposeLoginForm();
		// **************************************************
	}
}
