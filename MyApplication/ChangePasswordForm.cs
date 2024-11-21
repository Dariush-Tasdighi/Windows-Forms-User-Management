using System;
using Persistence;
using System.Linq;
using Infrastructure;
using System.Windows.Forms;

namespace MyApplication
{
	public partial class ChangePasswordForm : BaseForm
	{
		public ChangePasswordForm() : base()
		{
			InitializeComponent();
		}

		private void ChangePasswordForm_Load(object sender, EventArgs e)
		{
			if (Utility.AuthenticatedUser is null)
			{
				Application.Exit();
			}
		}

		private void ChangePasswordButton_Click(object sender, System.EventArgs e)
		{
			// **************************************************
			// **************************************************
			// **************************************************
			oldPasswordTextBox.Text =
				Utility.FixText(text: oldPasswordTextBox.Text);

			newPasswordTextBox.Text =
				Utility.FixText(text: newPasswordTextBox.Text);

			confirmNewPasswordTextBox.Text =
				Utility.FixText(text: confirmNewPasswordTextBox.Text);
			// **************************************************

			// **************************************************
			var errorMessages = string.Empty;

			if (oldPasswordTextBox.Text == string.Empty)
			{
				errorMessages =
					"Old password is required!";
			}
			// در زمان تغییر گذرواژه، نیازی به نوشتن دستورات ذیل نمی‌باشد
			//else
			//{
			//	if (oldPasswordTextBox.Text.Length < 8)
			//	{
			//		errorMessages =
			//			"The old password length should be greater than or equal to 8 characters!";
			//	}
			//}

			if (newPasswordTextBox.Text == string.Empty)
			{
				if (errorMessages != string.Empty)
				{
					errorMessages +=
						Environment.NewLine;
				}

				errorMessages +=
					"New password is required!";
			}
			else
			{
				if (newPasswordTextBox.Text.Length < 8)
				{
					if (errorMessages != string.Empty)
					{
						errorMessages +=
							Environment.NewLine;
					}

					errorMessages +=
						"The new password length should be greater than or equal to 8 characters!";
				}
			}

			if (confirmNewPasswordTextBox.Text == string.Empty)
			{
				if (errorMessages != string.Empty)
				{
					errorMessages +=
						Environment.NewLine;
				}

				errorMessages +=
					"Confirm new password is required!";
			}
			else
			{
				//if (confirmNewPasswordTextBox.Text != newPasswordTextBox.Text)
				if (string.Compare(confirmNewPasswordTextBox.Text,
					newPasswordTextBox.Text, ignoreCase: false) != 0)
				{
					if (errorMessages != string.Empty)
					{
						errorMessages +=
							Environment.NewLine;
					}

					errorMessages +=
						"The confirm new password is not equal to new password!";
				}
			}

			if (errorMessages != string.Empty)
			{
				MessageBox.Show(text: errorMessages);

				oldPasswordTextBox.Focus();

				return;
			}
			// **************************************************
			// **************************************************
			// **************************************************

			// **************************************************
			// از این قسمت به بعد باید سر کلاس نوشته شود
			// در ضمن، دقت کنید، چون دستورات فوق را سر کلاس نمی‌نویسید
			// در زمان ورود اطلاعات، برای تغییر گذرواژه، داده‌های درستی را خودتان وارد کنید
			// **************************************************

			if (Utility.AuthenticatedUser is null)
			{
				Application.Exit();
				return;
			}

			// از این قسمت به بعد باید سر کلاس نوشته شود

			try
			{
				using var applicationDbContext = new ApplicationDbContext();

				var currentUser =
					applicationDbContext.Users
					.Where(current => current.Id == Utility.AuthenticatedUser.Id)
					.FirstOrDefault();

				// **************************************************
				if (currentUser is null)
				{
					Application.Exit();
					return;
				}

				if (currentUser.IsActive == false)
				{
					Application.Exit();
					return;
				}
				// **************************************************

				//if (currentUser.Password != oldPasswordTextBox.Text)
				if (string.Compare(currentUser.Password,
					oldPasswordTextBox.Text, ignoreCase: false) != 0)
				{
					MessageBox.Show
						(text: "The old password is not correct!");

					oldPasswordTextBox.Focus();

					return;
				}

				// **************************************************
				currentUser.Password =
					newPasswordTextBox.Text;

				applicationDbContext.SaveChanges();
				// **************************************************

				MessageBox.Show
					(text: "Your password changed successfully.");

				ResetForm();

				//Close();
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
			oldPasswordTextBox.Text = string.Empty;
			newPasswordTextBox.Text = string.Empty;
			confirmNewPasswordTextBox.Text = string.Empty;

			oldPasswordTextBox.Focus();
		}
	}
}
