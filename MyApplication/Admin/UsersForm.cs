using Domain;
using System;
using Persistence;
using System.Linq;
using Infrastructure;
using System.Windows.Forms;
using System.Collections.Generic;

namespace MyApplication.Admin;

public partial class UsersForm : BaseForm
{
	public UsersForm() : base()
	{
		InitializeComponent();
	}

	private void UsersForm_Load(object sender, EventArgs e)
	{
		// **************************************************
		usersDataGridView.SelectionMode =
			DataGridViewSelectionMode.FullRowSelect;

		usersDataGridView.EditMode =
			DataGridViewEditMode.EditProgrammatically;
		// **************************************************

		// **************************************************
		//try
		//{
		//	using var databaseContext = new DatabaseContext();

		//	var users =
		//		databaseContext.Users
		//		.ToList()
		//		;

		//	usersDataGridView.DataSource = users;
		//}
		//catch (Exception ex)
		//{
		//	var errorMessage =
		//		$"Error: {ex.Message}";

		//	MessageBox.Show(text: errorMessage);
		//}
		// **************************************************
	}

	private void SearchButton_Click(object sender, EventArgs e)
	{
		Search();
	}

	private void Search()
	{
		try
		{
			using var databaseContext = new ApplicationDbContext();

			fullNameTextBox.Text =
				Utility.FixText(text: fullNameTextBox.Text);

			List<User> users;
			//var users; // Compile Error!
			//var users = null; // Compile Error!

			if (fullNameTextBox.Text == string.Empty)
			{
				users =
					databaseContext.Users
					.ToList()
					;
			}
			else
			{
				users =
					databaseContext.Users
					.Where(current => current.FullName != null &&
						current.FullName.ToLower().Contains(fullNameTextBox.Text.ToLower()))
					.ToList()
					;
			}

			usersDataGridView.DataSource = users;
		}
		catch (Exception ex)
		{
			var errorMessage =
				$"Error: {ex.Message}";

			MessageBox.Show(text: errorMessage);
		}

		fullNameTextBox.SelectAll();
		fullNameTextBox.Focus();
	}

	private void UsersDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
	{
		// روش احمقانه
		//var selectedUser =
		//	(User)usersDataGridView.Rows[e.RowIndex].DataBoundItem;

		// روش هوشمندانه
		var selectedUser =
			usersDataGridView.Rows[e.RowIndex].DataBoundItem as User;

		if (selectedUser is not null)
		{
			//MessageBox.Show(selectedUser.Username);

			var updateUserForm =
				new UpdateUserForm()
				{
					SelectedUser = selectedUser,
				};

			updateUserForm.ShowDialog();

			// دستور ذیل مهم است، به کاربرد آن دقت کنید
			Search();
		}
	}
}
