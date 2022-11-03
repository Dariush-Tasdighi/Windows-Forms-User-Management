namespace Infrastructure;

public static class Utility : object
{
	static Utility()
	{
		// Solution (3)
		//MainForm = new MyApplication.MainForm();
		//LoginForm = new MyApplication.LoginForm();
		//RegisterForm = new MyApplication.RegisterForm();
		// /Solution (3)
	}

	//public static string? FixText(string? text)
	//{
	//	if (text == null)
	//	{
	//		return null;
	//	}

	//	text =
	//		text.Trim();

	//	if (text.Length == 0)
	//	{
	//		return null;
	//	}

	//	while (text.Contains(value: "  "))
	//	{
	//		text =
	//			text.Replace
	//			(oldValue: "  ", newValue: " ");
	//	}

	//	return text;
	//}

	public static string FixText(string? text)
	{
		if (string.IsNullOrEmpty(value: text))
		{
			return string.Empty;
		}

		text =
			text.Trim();

		if (text.Length == 0)
		{
			return string.Empty;
		}

		while (text.Contains(value: "  "))
		{
			text =
				text.Replace
				(oldValue: "  ", newValue: " ");
		}

		return text;
	}

	// **************************************************
	// Solution (1)
	// **************************************************
	//public static MyApplication.MainForm MainForm;
	//public static MyApplication.LoginForm LoginForm;
	//public static MyApplication.RegisterForm RegisterForm;
	// **************************************************
	// /Solution (1)
	// **************************************************

	// **************************************************
	// Solution (2)
	// **************************************************
	//public static MyApplication.MainForm MainForm = new MyApplication.MainForm();
	//public static MyApplication.LoginForm LoginForm = new MyApplication.LoginForm();
	//public static MyApplication.RegisterForm RegisterForm = new MyApplication.RegisterForm();
	// **************************************************
	// /Solution (2)
	// **************************************************

	// **************************************************
	// Solution (3)
	// **************************************************
	//public static MyApplication.MainForm MainForm;
	//public static MyApplication.LoginForm LoginForm;
	//public static MyApplication.RegisterForm RegisterForm;
	// **************************************************
	// /Solution (3)
	// **************************************************

	// **************************************************
	// Solution (4)
	// **************************************************
	// **************************************************
	// **************************************************
	private static MyApplication.LoginForm? _loginForm;
	// **************************************************

	// **************************************************
	/// <summary>
	/// Lazy Loading = Lazy Initialization
	/// </summary>
	public static MyApplication.LoginForm LoginForm
	{
		get
		{
			if (_loginForm == null || _loginForm.IsDisposed)
			{
				_loginForm =
					new MyApplication.LoginForm();
			}

			return _loginForm;
		}
	}
	// **************************************************

	// **************************************************
	public static void DisposeLoginForm()
	{
		if (_loginForm != null)
		{
			if (_loginForm.IsDisposed == false)
			{
				_loginForm.Dispose();
			}

			_loginForm = null;
		}
	}
	// **************************************************
	// **************************************************
	// **************************************************

	// **************************************************
	// **************************************************
	// **************************************************
	private static MyApplication.RegisterForm? _registerForm;
	// **************************************************

	// **************************************************
	/// <summary>
	/// Lazy Loading = Lazy Initialization
	/// </summary>
	public static MyApplication.RegisterForm RegisterForm
	{
		get
		{
			if (_registerForm == null || _registerForm.IsDisposed)
			{
				_registerForm =
					new MyApplication.RegisterForm();
			}

			return _registerForm;
		}
	}
	// **************************************************

	// **************************************************
	public static void DisposeRegisterForm()
	{
		if (_registerForm != null)
		{
			if (_registerForm.IsDisposed == false)
			{
				_registerForm.Dispose();
			}

			_registerForm = null;
		}
	}
	// **************************************************
	// **************************************************
	// **************************************************

	// **************************************************
	// **************************************************
	// **************************************************
	private static MyApplication.MainForm? _mainForm;
	// **************************************************

	// **************************************************
	/// <summary>
	/// Lazy Loading = Lazy Initialization
	/// </summary>
	public static MyApplication.MainForm MainForm
	{
		get
		{
			if (_mainForm == null || _mainForm.IsDisposed)
			{
				_mainForm =
					new MyApplication.MainForm();
			}

			return _mainForm;
		}
	}
	// **************************************************

	// **************************************************
	public static void DisposeMainForm()
	{
		if (_mainForm != null)
		{
			if (_mainForm.IsDisposed == false)
			{
				_mainForm.Dispose();
			}

			_mainForm = null;
		}
	}
	// **************************************************
	// **************************************************
	// **************************************************
	// /Solution (4)
	// **************************************************

	// **************************************************
	//public static string? Username;
	//public static string? FullName;
	//public static System.Guid? UserId;
	// **************************************************

	// **************************************************
	public static Domain.User? AuthenticatedUser;
	// **************************************************

	public static void Exit()
	{
		var result =
			System.Windows.Forms.MessageBox.Show
			(text: "Are you sure?",
			caption: "Question",
			buttons: System.Windows.Forms.MessageBoxButtons.YesNo,
			icon: System.Windows.Forms.MessageBoxIcon.Question,
			defaultButton: System.Windows.Forms.MessageBoxDefaultButton.Button2);

		if (result == System.Windows.Forms.DialogResult.Yes)
		{
			System.Windows.Forms.Application.Exit();
		}
	}
}
