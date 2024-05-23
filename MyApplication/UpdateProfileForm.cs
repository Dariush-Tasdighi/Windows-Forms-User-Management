using System;
using Persistence;
using System.Linq;
using Infrastructure;
using System.Windows.Forms;

namespace MyApplication;

public partial class UpdateProfileForm : BaseForm
{
	public UpdateProfileForm() : base()
	{
		InitializeComponent();
	}

	private void UpdateProfileForm_Load(object sender, EventArgs e)
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

		// **************************************************
		//fullNameTextBox.Text =
		//	Utility.AuthenticatedUser.FullName;

		//descriptionTextBox.Text =
		//	Utility.AuthenticatedUser.Description;
		// **************************************************

		try
		{
			using var databaseContext = new DatabaseContext();

			var currentUser =
				databaseContext.Users
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

			fullNameTextBox.Text =
				currentUser.FullName;

			descriptionTextBox.Text =
				currentUser.Description;
		}
		catch (Exception ex)
		{
			MessageBox.Show(text: $"Error: {ex.Message}");
		}
	}

	private void SaveButton_Click(object sender, EventArgs e)
	{
		if (Utility.AuthenticatedUser is null)
		{
			Application.Exit();
			return;
		}

		try
		{
			using var databaseContext = new DatabaseContext();

			var currentUser =
				databaseContext.Users
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

			// **************************************************
			fullNameTextBox.Text =
				Utility.FixText(text: fullNameTextBox.Text);

			descriptionTextBox.Text =
				Utility.FixText(text: descriptionTextBox.Text);
			// **************************************************

			// **************************************************
			currentUser.FullName =
				fullNameTextBox.Text;

			currentUser.Description =
				descriptionTextBox.Text;

			databaseContext.SaveChanges();
			// **************************************************

			MessageBox.Show
				(text: "Your profile updated successfully...");

			// **************************************************
			Utility.AuthenticatedUser = currentUser;

			Utility.MainForm.ResetForm();
			// **************************************************

			// استفاده کنیم Close فرم به طور اتوماتیک بسته شود، می‌توانیم از دستور MessageBox اگر بخواهیم بعد از نمایش UpdateProfileForm در داخل
			//Close();
		}
		catch (Exception ex)
		{
			MessageBox.Show(text: $"Error: {ex.Message}");
		}
	}
}
