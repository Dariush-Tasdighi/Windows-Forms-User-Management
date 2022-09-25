namespace MyApplication
{
	internal static class Program
	{
		static Program()
		{
		}

		[System.STAThread]
		private static void Main()
		{
			ApplicationConfiguration.Initialize();

			// **************************************************
			//var mainForm = new LoginForm();

			//System.Windows.Forms.Application.Run(mainForm: mainForm);

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
			System.Windows.Forms.Application.Run
				(mainForm: Infrastructure.Utility.LoginForm);

			Infrastructure.Utility.DisposeLoginForm();
			// **************************************************
		}
	}
}
