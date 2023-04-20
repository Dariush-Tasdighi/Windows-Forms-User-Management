using System.Linq;

namespace MyApplication.Admin;

public partial class UpdateUserForm : Infrastructure.BaseForm
{
	public UpdateUserForm() : base()
	{
		InitializeComponent();
	}

	public Domain.User? SelectedUser { get; set; }

	private void UpdateUserForm_Load
		(object sender, System.EventArgs e)
	{
		ResetForm();
	}

	private void ResetButton_Click
		(object sender, System.EventArgs e)
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

		if (Infrastructure.Utility.AuthenticatedUser.IsAdmin == false)
		{
			Close();
			return;
		}

		if (SelectedUser == null)
		{
			Close();
			return;
		}

		if (Infrastructure.Utility.AuthenticatedUser.Id == SelectedUser.Id)
		{
			deleteButton.Enabled = false;
			isAdminCheckBox.Enabled = false;
			isActiveCheckBox.Enabled = false;
		}

		Data.DatabaseContext? databaseContext = null;

		try
		{
			databaseContext =
				new Data.DatabaseContext();

			var currentUser =
				databaseContext.Users
				.Where(current => current.Id == SelectedUser.Id)
				.FirstOrDefault();

			if (currentUser == null)
			{
				Close();
				return;
			}

			fullNameTextBox.Text =
				currentUser.FullName;

			descriptionTextBox.Text =
				currentUser.Description;

			isAdminCheckBox.Checked = currentUser.IsAdmin;
			isActiveCheckBox.Checked = currentUser.IsActive;
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

	private void UpdateButton_Click
		(object sender, System.EventArgs e)
	{
		if (Infrastructure.Utility.AuthenticatedUser == null)
		{
			System.Windows.Forms.Application.Exit();
			return;
		}

		if (SelectedUser == null)
		{
			Close();
			return;
		}

		Data.DatabaseContext? databaseContext = null;

		try
		{
			databaseContext =
				new Data.DatabaseContext();

			var currentUser =
				databaseContext.Users
				.Where(current => current.Id == SelectedUser.Id)
				.FirstOrDefault();

			if (currentUser == null)
			{
				Close();
				return;
			}

			currentUser.FullName =
				fullNameTextBox.Text;

			currentUser.Description =
				descriptionTextBox.Text;

			currentUser.IsAdmin = isAdminCheckBox.Checked;
			currentUser.IsActive = isActiveCheckBox.Checked;

			databaseContext.SaveChanges();

			// **************************************************
			//Infrastructure.Utility.AuthenticatedUser = currentUser;

			//Infrastructure.Utility.MainForm.ResetForm();
			// **************************************************

			System.Windows.Forms.MessageBox
				.Show(text: "User profile updated successfully...");

			// استفاده کنیم Close فرم به طور اتوماتیک بسته شود، می‌توانیم از دستور MessageBox اگر بخواهیم بعد از UpdateProfileForm در داخل
			//Close();

			if (Infrastructure.Utility.AuthenticatedUser.Id == SelectedUser.Id)
			{
				Infrastructure.Utility.AuthenticatedUser = currentUser;
				Infrastructure.Utility.MainForm.ResetForm();
			}
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

	private void DeleteButton_Click
		(object sender, System.EventArgs e)
	{
		if (Infrastructure.Utility.AuthenticatedUser == null)
		{
			System.Windows.Forms.Application.Exit();
			return;
		}

		if (SelectedUser == null)
		{
			Close();
			return;
		}

		Data.DatabaseContext? databaseContext = null;

		try
		{
			databaseContext =
				new Data.DatabaseContext();

			var currentUser =
				databaseContext.Users
				.Where(current => current.Id == SelectedUser.Id)
				.FirstOrDefault();

			if (currentUser == null)
			{
				Close();
				return;
			}

			databaseContext.Remove(entity: currentUser);
			//databaseContext.Users.Remove(entity: currentUser);

			databaseContext.SaveChanges();

			System.Windows.Forms.MessageBox
				.Show(text: "The User profile deleted successfully...");

			Close();
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
}
