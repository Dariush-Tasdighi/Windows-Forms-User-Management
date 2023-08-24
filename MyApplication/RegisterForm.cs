using System.Linq;

namespace MyApplication;

public partial class RegisterForm : Infrastructure.BaseForm
{
	public RegisterForm() : base()
	{
		InitializeComponent();
	}

	private void RegisterButton_Click(object sender, System.EventArgs e)
	{
		// **************************************************
		// **************************************************
		// **************************************************
		usernameTextBox.Text =
			Infrastructure.Utility
			.FixText(text: usernameTextBox.Text);

		passwordTextBox.Text =
			Infrastructure.Utility
			.FixText(text: passwordTextBox.Text);

		fullNameTextBox.Text =
			Infrastructure.Utility
			.FixText(text: fullNameTextBox.Text);

		if (usernameTextBox.Text == string.Empty
			|| passwordTextBox.Text == string.Empty)
		{
			var errorMessage =
				"Username and Password are requied!";

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
		var errorMessages = string.Empty;

		if (usernameTextBox.Text.Length < 6)
		{
			errorMessages =
				"Username length should be at least 6 characters!";
		}

		if (passwordTextBox.Text.Length < 8)
		{
			if (errorMessages != string.Empty)
			{
				errorMessages +=
					System.Environment.NewLine; // "\r\n"
			}

			errorMessages +=
				"Password length should be at least 8 characters!";
		}

		// اگر خطایی وجود داشت
		if (errorMessages != string.Empty)
		{
			System.Windows.Forms
				.MessageBox.Show(text: errorMessages);

			usernameTextBox.Focus();

			return;
		}
		// **************************************************
		// **************************************************
		// **************************************************

		// از این قسمت به بعد باید سر کلاس نوشته شود
		// در ضمن، دقت کنید، چون دستورات فوق را سر کلاس نمی‌نویسید
		// در زمان ورود اطلاعات، برای ثبت‌نام، داده‌های درستی را خودتان وارد کنید

		Persistence.DatabaseContext? databaseContext = null;

		try
		{
			databaseContext =
				new Persistence.DatabaseContext();

			var foundedUser =
				databaseContext.Users
				.Where(current => current.Username.ToLower() == usernameTextBox.Text.ToLower())
				.FirstOrDefault();

			if (foundedUser is not null)
			{
				var errorMessage =
					"This username is already exist! Please choose another one.";

				System.Windows.Forms
					.MessageBox.Show(text: errorMessage);

				usernameTextBox.Focus();

				return;
			}

			var newUser =
				new Domain.User
				(username: usernameTextBox.Text, password: passwordTextBox.Text)
				{
					// دستور ذیل، بستگی به سناریو و قواعد و قوانین شرکت یا پروژه دارد
					IsActive = true,

					FullName = fullNameTextBox.Text,
				};

			databaseContext.Add(entity: newUser);
			//databaseContext.Users.Add(entity: newUser);

			databaseContext.SaveChanges();

			System.Windows.Forms.MessageBox
				.Show(text: "Registration Done!");

			// **************************************************
			//fullNameTextBox.Text = string.Empty;
			//passwordTextBox.Text = string.Empty;
			//usernameTextBox.Text = string.Empty;

			//usernameTextBox.Focus();
			// **************************************************

			// **************************************************
			// DRY = Don't Repeat Yourself!
			// **************************************************

			// **************************************************
			// دقت داشته باشید، هر چند که دستور ذیل کاملا صحیح می‌باشد
			// ولی شیک‌تر آن است که از تابع بعدی استفاده نماییم
			//ResetButton_Click(null, null);
			// **************************************************

			// **************************************************
			ResetForm();
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
		}
	}

	private void ResetButton_Click
		(object sender, System.EventArgs e)
	{
		//fullNameTextBox.Text = string.Empty;
		//passwordTextBox.Text = string.Empty;
		//usernameTextBox.Text = string.Empty;

		//usernameTextBox.Focus();

		ResetForm();
	}

	public void ResetForm()
	{
		passwordTextBox.Text = string.Empty;
		usernameTextBox.Text = string.Empty;
		fullNameTextBox.Text = string.Empty;

		usernameTextBox.Focus();
	}

	private void LoginButton_Click
		(object sender, System.EventArgs e)
	{
		// **************************************************
		// دستورات ذیل احمقانه می‌باشد
		// **************************************************
		//Hide();

		//var loginForm = new LoginForm();
		//loginForm.Show();
		// **************************************************

		// **************************************************
		//Hide();

		//Infrastructure.Utility.LoginForm.Show();
		// **************************************************

		// **************************************************
		Hide();

		Infrastructure.Utility.LoginForm.ResetForm();
		Infrastructure.Utility.LoginForm.Show();
		// **************************************************
	}

	private void ExitButton_Click
		(object sender, System.EventArgs e)
	{
		Infrastructure.Utility.Exit();
	}
}
