using Domain;
using System;
using System.Linq;
using Persistence;
using Infrastructure;
using System.Windows.Forms;

namespace MyApplication;

public partial class RegisterForm : BaseForm
{
	public RegisterForm() : base()
	{
		InitializeComponent();
	}

	private void RegisterButton_Click(object sender, EventArgs e)
	{
		// **************************************************
		// **************************************************
		// **************************************************
		usernameTextBox.Text =
			Utility.FixText(text: usernameTextBox.Text);

		passwordTextBox.Text =
			Utility.FixText(text: passwordTextBox.Text);

		fullNameTextBox.Text =
			Utility.FixText(text: fullNameTextBox.Text);
		// **************************************************

		// **************************************************
		if (usernameTextBox.Text == string.Empty
			|| passwordTextBox.Text == string.Empty)
		{
			var errorMessage =
				"Username and Password are requied!";

			MessageBox.Show(text: errorMessage);

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
					Environment.NewLine; // "\r\n"
			}

			errorMessages +=
				"Password length should be at least 8 characters!";
		}

		// اگر خطایی وجود داشت
		if (errorMessages != string.Empty)
		{
			MessageBox.Show(text: errorMessages);

			usernameTextBox.Focus();

			return;
		}
		// **************************************************
		// **************************************************
		// **************************************************

		// **************************************************
		// از این قسمت به بعد باید سر کلاس نوشته شود
		// در ضمن، دقت کنید، چون دستورات فوق را سر کلاس نمی‌نویسید
		// در زمان ورود اطلاعات، برای ثبت‌نام، داده‌های درستی را خودتان وارد کنید
		// **************************************************

		try
		{
			using var applicationDbContext = new ApplicationDbContext();

			var foundUser =
				applicationDbContext.Users
				.Where(current => current.Username.ToLower() == usernameTextBox.Text.ToLower())
				.FirstOrDefault();

			if (foundUser is not null)
			{
				var errorMessage =
					"This username is already exist! Please choose another one.";

				MessageBox.Show(text: errorMessage);

				usernameTextBox.Focus();

				return;
			}

			var newUser =
				new User(username: usernameTextBox.Text, password: passwordTextBox.Text)
				{
					// دستور ذیل، بستگی به سناریو و قواعد و قوانین شرکت یا پروژه دارد
					IsActive = true,

					FullName = fullNameTextBox.Text,
				};

			applicationDbContext.Add(entity: newUser);
			//applicationDbContext.Users.Add(entity: newUser);

			applicationDbContext.SaveChanges();

			MessageBox.Show(text: "Registration Done!");

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
		catch (Exception ex)
		{
			var errorMessage =
				$"Error: {ex.Message}";

			MessageBox.Show(text: errorMessage);
		}
	}

	private void ResetButton_Click(object sender, EventArgs e)
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

	private void LoginButton_Click(object sender, EventArgs e)
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

		//Utility.LoginForm.Show();
		// **************************************************

		// **************************************************
		Hide();

		Utility.LoginForm.ResetForm();
		Utility.LoginForm.Show();
		// **************************************************
	}

	private void ExitButton_Click(object sender, EventArgs e)
	{
		Utility.Exit();
	}
}
