using System.Linq;

namespace MyApplication
{
	public partial class UpdateProfileForm : Infrastructure.BaseForm
	{
		public UpdateProfileForm() : base()
		{
			InitializeComponent();
		}

		private void UpdateProfileForm_Load(object sender, System.EventArgs e)
		{
			ResetForm();
		}

		private void ResetButton_Click(object sender, System.EventArgs e)
		{
			ResetForm();
		}

		private void ResetForm()
		{
			if (Infrastructure.Utility.AuthenticatedUser == null)
			{
				System.Windows.Forms.Application.Exit();
				return;
			}

			// **************************************************
			//fullNameTextBox.Text =
			//	Infrastructure.Utility.AuthenticatedUser.FullName;

			//descriptionTextBox.Text =
			//	Infrastructure.Utility.AuthenticatedUser.Description;
			// **************************************************

			Data.DatabaseContext? databaseContext = null;

			try
			{
				databaseContext =
					new Data.DatabaseContext();

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

				fullNameTextBox.Text =
					currentUser.FullName;

				descriptionTextBox.Text =
					currentUser.Description;
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

		private void SaveButton_Click(object sender, System.EventArgs e)
		{
			if (Infrastructure.Utility.AuthenticatedUser == null)
			{
				System.Windows.Forms.Application.Exit();
				return;
			}

			Data.DatabaseContext? databaseContext = null;

			try
			{
				databaseContext =
					new Data.DatabaseContext();

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

				currentUser.FullName =
					fullNameTextBox.Text;

				currentUser.Description =
					descriptionTextBox.Text;

				databaseContext.SaveChanges();

				// **************************************************
				Infrastructure.Utility.AuthenticatedUser = currentUser;

				Infrastructure.Utility.MainForm.ResetForm();
				// **************************************************

				System.Windows.Forms.MessageBox
					.Show(text: "Your profile updated successfully...");

				// استفاده کنیم Close فرم به طور اتوماتیک بسته شود، می‌توانیم از دستور MessageBox اگر بخواهیم بعد از UpdateProfileForm در داخل
				//Close();
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
	}
}
