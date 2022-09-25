using Infrastructure;
using Microsoft.Data.SqlClient.Server;
using System.Linq;

namespace MyApplication
{
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
				Utility.FixText(usernameTextBox.Text);

			passwordTextBox.Text =
				Utility.FixText(passwordTextBox.Text);
			// **************************************************

			// **************************************************
			if (usernameTextBox.Text == string.Empty || passwordTextBox.Text == string.Empty)
			{
				System.Windows.Forms.MessageBox
					.Show(text: "Username and Password is requied!");

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
			// **************************************************

			// **************************************************
			if (usernameTextBox.Text.Length < 6)
			{
				errorMessages =
					"Username length should be at least 6 characters!";
			}
			// **************************************************

			// **************************************************
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
			// **************************************************

			// **************************************************
			// اگر خطایی وجود داشت
			if (errorMessages != string.Empty)
			{
				System.Windows.Forms.MessageBox.Show(text: errorMessages);

				usernameTextBox.Focus();

				return;
			}
			// **************************************************
			// **************************************************
			// **************************************************

			// از این قسمت به بعد باید سر کلاس نوشته شود
			// در ضمن، دقت کنید، چون دستورات فوق را سر کلاس نمی‌نویسید
			// در زمان ورود اطلاعات، برای ثبت‌نام، داده‌های درستی را خودتان وارد کنید

			Data.DatabaseContext? databaseContext = null;

			try
			{
				databaseContext =
					new Data.DatabaseContext();

				var foundedUser =
					databaseContext.Users
					.Where(current => current.Username.ToLower() == usernameTextBox.Text!.ToLower())
					.FirstOrDefault();

				if (foundedUser != null)
				{
					System.Windows.Forms.MessageBox.Show
						(text: "This username is already exist! Please choose another one...");

					usernameTextBox.Focus();

					return;
				}

				var newUser =
					new Domain.User
					(username: usernameTextBox.Text, password: passwordTextBox.Text)
					{
						// بستگی به سناریو و قواعد و قوانین شرکت یا پروژه دارد
						IsActive = true,
					};

				databaseContext.Add(entity: newUser);
				//databaseContext.Users.Add(entity: newUser);

				databaseContext.SaveChanges();

				System.Windows.Forms.MessageBox
					.Show(text: "Registration Done!");

				// **************************************************
				//passwordTextBox.Text = string.Empty;
				//usernameTextBox.Text = string.Empty;

				//usernameTextBox.Focus();
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
				if (databaseContext != null)
				{
					databaseContext.Dispose();
					databaseContext = null;
				}
			}
		}

		private void ResetButton_Click(object sender, System.EventArgs e)
		{
			//passwordTextBox.Text = string.Empty;
			//usernameTextBox.Text = string.Empty;

			//usernameTextBox.Focus();

			ResetForm();
		}

		public void ResetForm()
		{
			passwordTextBox.Text = string.Empty;
			usernameTextBox.Text = string.Empty;

			usernameTextBox.Focus();
		}

		private void LoginButton_Click
			(object sender, System.EventArgs e)
		{
			// **************************************************
			//var loginForm = new LoginForm();
			//loginForm.Show();
			//Hide();
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
	}
}
