﻿using System;
using Persistence;
using System.Linq;
using Infrastructure;
using System.Windows.Forms;

namespace MyApplication;

public partial class LoginForm : BaseForm
{
	public LoginForm() : base()
	{
		InitializeComponent();
	}

	private void LoginButton_Click(object sender, EventArgs e)
	{
		// **************************************************
		usernameTextBox.Text =
			Utility.FixText(text: usernameTextBox.Text);

		passwordTextBox.Text =
			Utility.FixText(text: passwordTextBox.Text);
		// **************************************************

		// **************************************************
		if (usernameTextBox.Text == string.Empty
			|| passwordTextBox.Text == string.Empty)
		{
			var errorMessage =
				"Username and Password are required!";

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
		// از این قسمت به بعد، باید سر کلاس نوشته شود
		// **************************************************

		try
		{
			//var applicationDbContext = new ApplicationDbContext();
			using var applicationDbContext = new ApplicationDbContext();

			var foundUser =
				applicationDbContext.Users
				.Where(current => current.Username.ToLower() == usernameTextBox.Text.ToLower())
				.FirstOrDefault();

			if (foundUser is null)
			//if (foundUser == null)
			{
				// پیغام ذیل کاملا دقیق بوده، ولی از نظر مسائل امنیتی صلاح نیست

				//var errorMessage =
				//	"Username is not correct!";

				//MessageBox.Show(text: errorMessage);

				// دقت کنید که در این حالت، پیغام خطا باید گنگ باشد

				var errorMessage =
					"Username and/or Password is not correct!";

				MessageBox.Show(text: errorMessage);

				usernameTextBox.Focus();

				return;
			}

			//if (foundUser.Password != passwordTextBox.Text)
			//{
			//}

			if (string.Compare(foundUser.Password,
				passwordTextBox.Text, ignoreCase: false) != 0)
			{
				// پیغام ذیل کاملا دقیق بوده، ولی از نظر مسائل امنیتی صلاح نیست

				//var errorMessage =
				//	"Password is not correct!";

				//MessageBox.Show(text: errorMessage);

				// دقت کنید که در این حالت، پیغام خطا باید گنگ باشد

				var errorMessage =
					"Username and/or Password is not correct!";

				MessageBox.Show(text: errorMessage);

				usernameTextBox.Focus();

				return;
			}

			//if (!foundUser.IsActive)
			//{
			//}

			if (foundUser.IsActive == false)
			{
				var errorMessage =
					"You can not login right now! Please contact support.";

				MessageBox.Show(text: errorMessage);

				usernameTextBox.Focus();

				return;
			}

			// **************************************************
			//MessageBox.Show(text: "Welcome!");

			//return;
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
			//Utility.AuthenticatedUser = foundUser;

			//Hide();

			//var mainForm = new MainForm();
			//mainForm.Show();
			// **************************************************

			// **************************************************
			// *** روش هوشمندانه ********************************
			// **************************************************
			Utility.AuthenticatedUser = foundUser;

			Hide();

			Utility.MainForm.ResetForm();
			Utility.MainForm.Show();
			// **************************************************
			// **************************************************
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
		ResetForm();
	}

	public void ResetForm()
	{
		usernameTextBox.Text = string.Empty;
		passwordTextBox.Text = string.Empty;

		usernameTextBox.Focus();
	}

	private void RegisterButton_Click(object sender, EventArgs e)
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

		//Utility.RegisterForm.Show();
		// **************************************************

		// **************************************************
		Hide();

		Utility.RegisterForm.ResetForm();
		Utility.RegisterForm.Show();
		// **************************************************
	}

	private void ExitButton_Click(object sender, EventArgs e)
	{
		Utility.Exit();
	}
}
