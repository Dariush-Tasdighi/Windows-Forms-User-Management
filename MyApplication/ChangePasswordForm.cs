using System.Linq;

namespace MyApplication
{
	public partial class ChangePasswordForm : Infrastructure.BaseForm
	{
		public ChangePasswordForm() : base()
		{
			InitializeComponent();
		}

		private void ChangePasswordForm_Load
			(object sender, System.EventArgs e)
		{
			if (Infrastructure.Utility.AuthenticatedUser == null)
			{
				System.Windows.Forms.Application.Exit();
			}
		}

		private void ChangePasswordButton_Click(object sender, System.EventArgs e)
		{
			// **************************************************
			// **************************************************
			// **************************************************
			oldPasswordTextBox.Text =
				Infrastructure.Utility.FixText
				(text: oldPasswordTextBox.Text);

			newPasswordTextBox.Text =
				Infrastructure.Utility.FixText
				(text: newPasswordTextBox.Text);

			confirmNewPasswordTextBox.Text =
				Infrastructure.Utility.FixText
				(text: confirmNewPasswordTextBox.Text);
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
						System.Environment.NewLine;
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
							System.Environment.NewLine;
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
						System.Environment.NewLine;
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
							System.Environment.NewLine;
					}

					errorMessages +=
						"The confirm new password is not equal to new password!";
				}
			}

			if (errorMessages != string.Empty)
			{
				System.Windows.Forms
					.MessageBox.Show(text: errorMessages);

				oldPasswordTextBox.Focus();

				return;
			}
			// **************************************************
			// **************************************************
			// **************************************************

			if (Infrastructure.Utility.AuthenticatedUser == null)
			{
				System.Windows.Forms.Application.Exit();
				return;
			}

			// از این قسمت به بعد باید سر کلاس نوشته شود

			Persistence.DatabaseContext? databaseContext = null;

			try
			{
				databaseContext =
					new Persistence.DatabaseContext();

				var currentUser =
					databaseContext.Users
					.Where(current => current.Id == Infrastructure.Utility.AuthenticatedUser.Id)
					.FirstOrDefault();

				// **************************************************
				if (currentUser == null)
				{
					System.Windows.Forms.Application.Exit();
					return;
				}

				if (currentUser.IsActive == false)
				{
					System.Windows.Forms.Application.Exit();
					return;
				}
				// **************************************************

				//if (currentUser.Password != oldPasswordTextBox.Text)
				if (string.Compare(currentUser.Password,
					oldPasswordTextBox.Text, ignoreCase: false) != 0)
				{
					System.Windows.Forms.MessageBox
						.Show(text: "The old password is not correct!");

					oldPasswordTextBox.Focus();

					return;
				}

				// **************************************************
				currentUser.Password =
					newPasswordTextBox.Text;

				databaseContext.SaveChanges();
				// **************************************************

				System.Windows.Forms.MessageBox
					.Show(text: "Your password changed successfully.");

				ResetForm();

				//Close();
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
			oldPasswordTextBox.Text = string.Empty;
			newPasswordTextBox.Text = string.Empty;
			confirmNewPasswordTextBox.Text = string.Empty;

			oldPasswordTextBox.Focus();
		}
	}
}
