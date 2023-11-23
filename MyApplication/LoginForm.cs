using System.Linq;

namespace MyApplication;

public partial class LoginForm : Infrastructure.BaseForm
{
	public LoginForm() : base()
	{
		InitializeComponent();
	}

	private void LoginButton_Click
		(object sender, System.EventArgs e)
	{
		// **************************************************
		usernameTextBox.Text =
			Infrastructure.Utility
			.FixText(text: usernameTextBox.Text);

		passwordTextBox.Text =
			Infrastructure.Utility
			.FixText(text: passwordTextBox.Text);

		if (usernameTextBox.Text == string.Empty
			|| passwordTextBox.Text == string.Empty)
		{
			var errorMessage =
				"Username and Password are required!";

			System.Windows.Forms.MessageBox.Show(text: errorMessage);

			if (usernameTextBox.Text == string.Empty)
			{
				usernameTextBox.Focus();
			}
			else
			{
				passwordTextBox.Focus();
			}

			return;
		}
		// **************************************************

		// **************************************************
		// از این قسمت به بعد، باید سر کلاس نوشته شود
		// **************************************************

		// **************************************************
		//Persistence.DatabaseContext? databaseContext = null;

		//try
		//{
		//	databaseContext =
		//		new Persistence.DatabaseContext();

		//	// کار می‌کنیم databaseContext با
		//}
		//catch (System.Exception ex)
		//{
		//	// می‌کنیم Log خطا را

		//	var errorMessage =
		//		"خطای ناشناخته‌ای صورت گرفته است، لطفا با تیم پشتیبانی تماس حاصل فرمایید";

		//	System.Windows.Forms.MessageBox.Show(text: errorMessage);
		//}
		//finally
		//{
		//	//if (databaseContext != null)
		//	//{
		//	//	databaseContext.Dispose();
		//	//	databaseContext = null;
		//	//}

		//	//if (databaseContext is not null)
		//	//{
		//	//	databaseContext.Dispose();
		//	//	databaseContext = null;
		//	//}

		//	//if (databaseContext is not null)
		//	//{
		//	//	databaseContext.Dispose();
		//	//}

		//	databaseContext?.Dispose();
		//}
		// **************************************************

		Persistence.DatabaseContext? databaseContext = null;

		try
		{
			databaseContext =
				new Persistence.DatabaseContext();

			//var foundedUser =
			//	databaseContext.Users
			//	// using System.Linq;
			//	.Where(current => current.Username == usernameTextBox.Text)
			//	// using System.Linq;
			//	.FirstOrDefault();

			// کار نمی‌کند EF Core در
			//var foundedUser =
			//	databaseContext.Users
			//	.Where(current => string.Compare(current.Username, usernameTextBox.Text, true) == 0)
			//	.FirstOrDefault();

			var foundedUser =
				databaseContext.Users
				.Where(current => current.Username.ToLower() == usernameTextBox.Text.ToLower())
				.FirstOrDefault();

			if (foundedUser is null)
			{
				// پیغام ذیل کاملا دقیق بوده، ولی از نظر مسائل امنیتی صلاح نیست

				//System.Windows.Forms.MessageBox
				//	.Show(text: "Username is not correct!");

				// دقت کنید که در این حالت، پیغام خطا باید گنگ باشد

				var errorMessage =
					"Username and/or Password is not correct!";

				System.Windows.Forms.MessageBox.Show(text: errorMessage);

				usernameTextBox.Focus();

				return;
			}

			if (string.Compare(foundedUser.Password,
				passwordTextBox.Text, ignoreCase: false) != 0)
			{
				// پیغام ذیل کاملا دقیق بوده، ولی از نظر مسائل امنیتی صلاح نیست

				//System.Windows.Forms.MessageBox
				//	.Show(text: "Password is not correct!");

				// دقت کنید که در این حالت، پیغام خطا باید گنگ باشد

				var errorMessage =
					"Username and/or Password is not correct!";

				System.Windows.Forms.MessageBox.Show(text: errorMessage);

				usernameTextBox.Focus();

				return;
			}

			if (foundedUser.IsActive == false)
			{
				var errorMessage =
					"You can not login right now! Please contact support.";

				System.Windows.Forms.MessageBox.Show(text: errorMessage);

				usernameTextBox.Focus();

				return;
			}

			// **************************************************
			//System.Windows.Forms.MessageBox.Show(text: "Welcome!");
			// **************************************************

			// **************************************************
			// روش احمقانه
			// **************************************************
			//Hide();

			//var mainForm = new MainForm();
			//mainForm.Show();
			// **************************************************

			// **************************************************
			// روش احمقانه
			// **************************************************
			Infrastructure.Utility.AuthenticatedUser = foundedUser;

			Hide();

			var mainForm = new MainForm();
			mainForm.Show();
			// **************************************************

			// **************************************************
			// *** روش هوشمندانه ********************************
			// **************************************************
			//Infrastructure.Utility.AuthenticatedUser = foundedUser;

			//Hide();
			//Infrastructure.Utility.MainForm.ResetForm();
			//Infrastructure.Utility.MainForm.Show();
			// **************************************************
			// **************************************************
			// **************************************************
		}
		catch (System.Exception ex)
		{
			System.Windows.Forms.MessageBox
				.Show(text: $"Error: {ex.Message}");
		}
		finally
		{
			databaseContext?.Dispose();
			databaseContext = null;
		}
	}

	private void ResetButton_Click
		(object sender, System.EventArgs e)
	{
		ResetForm();
	}

	public void ResetForm()
	{
		usernameTextBox.Text = string.Empty;
		passwordTextBox.Text = string.Empty;

		usernameTextBox.Focus();
	}

	private void RegisterButton_Click
		(object sender, System.EventArgs e)
	{
		// **************************************************
		// دستورات ذیل کار نمی‌کند
		// **************************************************
		//Close();

		//var registerForm = new RegisterForm();
		//registerForm.Show();
		// **************************************************

		// **************************************************
		// دستورات ذیل کار نمی‌کند
		// **************************************************
		//var registerForm = new RegisterForm();
		//registerForm.Show();

		//Close();
		// **************************************************

		// **************************************************
		// دستورات ذیل احمقانه می‌باشد
		// **************************************************
		//Hide();

		//var registerForm = new RegisterForm();
		//registerForm.Show();
		// **************************************************

		// **************************************************
		//var registerForm = new RegisterForm();
		//registerForm.Show();
		//Hide();
		// **************************************************

		// **************************************************
		//Hide();

		//Infrastructure.Utility.RegisterForm.Show();
		// **************************************************

		// **************************************************
		Hide();

		Infrastructure.Utility.RegisterForm.ResetForm();
		Infrastructure.Utility.RegisterForm.Show();
		// **************************************************
	}

	private void ExitButton_Click
		(object sender, System.EventArgs e)
	{
		Infrastructure.Utility.Exit();
	}
}
