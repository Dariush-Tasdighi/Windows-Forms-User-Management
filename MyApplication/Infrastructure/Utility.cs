using Domain;
using MyApplication;
using System.Windows.Forms;

namespace Infrastructure;

public static class Utility : object
{
	static Utility()
	{
		// Solution (3)
		//MainForm = new();
		//LoginForm = new();
		//RegisterForm = new();
		// /Solution (3)
	}

	//public static string? FixText(string? text)
	//{
	//	if (text is null)
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
		if (string.IsNullOrWhiteSpace(value: text))
		{
			return string.Empty;
		}

		text =
			text.Trim();

		//text =
		//	text.TrimStart().TrimEnd();

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
	//public static MainForm MainForm;
	//public static LoginForm LoginForm;
	//public static RegisterForm RegisterForm;
	// **************************************************
	// /Solution (1)
	// **************************************************

	// **************************************************
	// Solution (2)
	// **************************************************
	//public static MainForm MainForm = new();
	//public static LoginForm LoginForm = new();
	//public static RegisterForm RegisterForm = new();
	// **************************************************
	// /Solution (2)
	// **************************************************

	// **************************************************
	// Solution (3)
	// **************************************************
	//public static MainForm MainForm;
	//public static LoginForm LoginForm;
	//public static RegisterForm RegisterForm;
	// **************************************************
	// /Solution (3)
	// **************************************************

	// **************************************************
	// Solution (4)
	// **************************************************
	private static LoginForm? _loginForm;

	/// <summary>
	/// Lazy Loading = Lazy Initialization
	/// </summary>
	public static LoginForm LoginForm
	{
		get
		{
			if (_loginForm is null || _loginForm.IsDisposed)
			{
				_loginForm =
					new LoginForm();
			}

			return _loginForm;
		}
	}

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
	private static RegisterForm? _registerForm;

	/// <summary>
	/// Lazy Loading = Lazy Initialization
	/// </summary>
	public static RegisterForm RegisterForm
	{
		get
		{
			if (_registerForm is null || _registerForm.IsDisposed)
			{
				_registerForm =
					new RegisterForm();
			}

			return _registerForm;
		}
	}

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
	private static MainForm? _mainForm;

	/// <summary>
	/// Lazy Loading = Lazy Initialization
	/// </summary>
	public static MainForm MainForm
	{
		get
		{
			if (_mainForm is null || _mainForm.IsDisposed)
			{
				_mainForm =
					new MainForm();
			}

			return _mainForm;
		}
	}

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
	// /Solution (4)
	// **************************************************

	// **************************************************
	//public static bool IsAdmin;
	// **************************************************

	// **************************************************
	//public static bool IsAdmin;
	//public static Guid? UserId;
	// **************************************************

	// **************************************************
	//public static bool IsAdmin;
	//public static Guid? UserId;
	//public static string? Username;
	// **************************************************

	// **************************************************
	//public static bool IsAdmin;
	//public static Guid? UserId;
	//public static string? Username;
	//public static string? FullName;
	// **************************************************

	// **************************************************
	//public static User? AuthenticatedUser;
	// **************************************************

	// **************************************************
	public static User? AuthenticatedUser { get; set; }
	// **************************************************

	public static bool Exit()
	{
		var result =
			MessageBox.Show
			(text: "Are you sure?",
			caption: "Question",
			buttons: MessageBoxButtons.YesNo,
			icon: MessageBoxIcon.Question,
			defaultButton: MessageBoxDefaultButton.Button2);

		if (result == DialogResult.Yes)
		{
			Application.Exit();

			return true;
		}
		else
		{
			return false;
		}
	}
}
