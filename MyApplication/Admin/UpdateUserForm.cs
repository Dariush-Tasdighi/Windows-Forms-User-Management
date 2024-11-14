using Domain;
using System;
using Persistence;
using System.Linq;
using Infrastructure;
using System.Windows.Forms;

namespace MyApplication.Admin;

public partial class UpdateUserForm : BaseForm
{
	public UpdateUserForm() : base()
	{
		InitializeComponent();
	}

	public User? SelectedUser { get; set; }

	private void UpdateUserForm_Load(object sender, EventArgs e)
	{
		ResetForm();
	}

	private void ResetButton_Click(object sender, EventArgs e)
	{
		ResetForm();
	}

	private void ResetForm()
	{
		if (Utility.AuthenticatedUser is null)
		{
			Application.Exit();
			return;
		}

		if (Utility.AuthenticatedUser.IsAdmin == false)
		{
			Close();
			return;
		}

		if (SelectedUser is null)
		{
			Close();
			return;
		}

		if (Utility.AuthenticatedUser.Id == SelectedUser.Id)
		{
			deleteButton.Enabled = false;
			isAdminCheckBox.Enabled = false;
			isActiveCheckBox.Enabled = false;
		}

		try
		{
			using var databaseContext = new ApplicationDbContext();

			var currentUser =
				databaseContext.Users
				.Where(current => current.Id == SelectedUser.Id)
				.FirstOrDefault();

			if (currentUser is null)
			{
				Close();
				return;
			}

			isAdminCheckBox.Checked = currentUser.IsAdmin;
			isActiveCheckBox.Checked = currentUser.IsActive;

			fullNameTextBox.Text = currentUser.FullName;
			descriptionTextBox.Text = currentUser.Description;
		}
		catch (Exception ex)
		{
			var errorMessage =
				$"Error: {ex.Message}";

			MessageBox.Show(text: errorMessage);
		}
	}

	private void UpdateButton_Click(object sender, EventArgs e)
	{
		if (Utility.AuthenticatedUser is null)
		{
			Application.Exit();
			return;
		}

		if (Utility.AuthenticatedUser.IsAdmin == false)
		{
			Close();
			return;
		}

		if (SelectedUser is null)
		{
			Close();
			return;
		}

		try
		{
			using var databaseContext = new ApplicationDbContext();

			var currentUser =
				databaseContext.Users
				.Where(current => current.Id == SelectedUser.Id)
				.FirstOrDefault();

			if (currentUser is null)
			{
				Close();
				return;
			}

			// **************************************************
			fullNameTextBox.Text =
				Utility.FixText(text: fullNameTextBox.Text);

			descriptionTextBox.Text =
				Utility.FixText(text: descriptionTextBox.Text);
			// **************************************************

			currentUser.IsAdmin = isAdminCheckBox.Checked;
			currentUser.IsActive = isActiveCheckBox.Checked;

			currentUser.FullName = fullNameTextBox.Text;
			currentUser.Description = descriptionTextBox.Text;

			databaseContext.SaveChanges();

			// **************************************************
			//Utility.AuthenticatedUser = currentUser;

			//Utility.MainForm.ResetForm();
			// **************************************************

			MessageBox.Show
				(text: "User profile updated successfully...");

			// استفاده کنیم Close فرم به طور اتوماتیک بسته شود، می‌توانیم از دستور MessageBox اگر بخواهیم بعد از UpdateProfileForm در داخل
			//Close();

			if (Utility.AuthenticatedUser.Id == SelectedUser.Id)
			{
				Utility.AuthenticatedUser = currentUser;
				Utility.MainForm.ResetForm();
			}
		}
		catch (Exception ex)
		{
			var errorMessage =
				$"Error: {ex.Message}";

			MessageBox.Show(text: errorMessage);
		}
	}

	private void DeleteButton_Click(object sender, EventArgs e)
	{
		if (Utility.AuthenticatedUser is null)
		{
			Application.Exit();
			return;
		}

		if (Utility.AuthenticatedUser.IsAdmin == false)
		{
			Close();
			return;
		}

		if (SelectedUser is null)
		{
			Close();
			return;
		}

		try
		{
			using var databaseContext = new ApplicationDbContext();

			var currentUser =
				databaseContext.Users
				.Where(current => current.Id == SelectedUser.Id)
				.FirstOrDefault();

			if (currentUser is null)
			{
				Close();
				return;
			}

			// EF Core
			databaseContext.Remove(entity: currentUser);

			// EF / EF Core
			//databaseContext.Users.Remove(entity: currentUser);

			databaseContext.SaveChanges();

			MessageBox.Show
				(text: "The User profile deleted successfully...");

			Close();
		}
		catch (Exception ex)
		{
			var errorMessage =
				$"Error: {ex.Message}";

			MessageBox.Show(text: errorMessage);
		}
	}
}
