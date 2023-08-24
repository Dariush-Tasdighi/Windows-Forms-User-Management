using System.Linq;

namespace MyApplication.Admin;

public partial class UsersForm : Infrastructure.BaseForm
{
	public UsersForm() : base()
	{
		InitializeComponent();
	}

	private void UsersForm_Load
		(object sender, System.EventArgs e)
	{
		usersDataGridView.SelectionMode =
			System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

		usersDataGridView.EditMode =
			System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
	}

	private void SearchButton_Click
		(object sender, System.EventArgs e)
	{
		Search();
	}

	private void Search()
	{
		Persistence.DatabaseContext? databaseContext = null;

		try
		{
			databaseContext =
				new Persistence.DatabaseContext();

			fullNameTextBox.Text =
				Infrastructure.Utility
				.FixText(text: fullNameTextBox.Text);

			//var users = null;

			System.Collections.Generic.List<Domain.User> users;

			if (fullNameTextBox.Text == string.Empty)
			{
				users =
					databaseContext.Users
					.ToList()
					;
			}
			else
			{
				//users =
				//	databaseContext.Users
				//	.Where(current => current.FullName == fullNameTextBox.Text)
				//	.ToList()
				//	;

				//users =
				//	databaseContext.Users
				//	.Where(current => current.FullName.ToLower() == fullNameTextBox.Text.ToLower())
				//	.ToList()
				//	;

				//users =
				//	databaseContext.Users
				//	.Where(current => current.FullName != null &&
				//		current.FullName.ToLower() == fullNameTextBox.Text.ToLower())
				//	.ToList()
				//	;

				//users =
				//	databaseContext.Users
				//	.Where(current => current.FullName != null &&
				//		current.FullName.ToLower().StartsWith(fullNameTextBox.Text.ToLower()))
				//	.ToList()
				//	;

				//users =
				//	databaseContext.Users
				//	.Where(current => current.FullName != null &&
				//		current.FullName.ToLower().EndsWith(fullNameTextBox.Text.ToLower()))
				//	.ToList()
				//	;

				users =
					databaseContext.Users
					.Where(current => current.FullName != null &&
						current.FullName.ToLower().Contains(fullNameTextBox.Text.ToLower()))
					.ToList()
					;
			}

			usersDataGridView.DataSource = users;

			fullNameTextBox.SelectAll();
			fullNameTextBox.Focus();
		}
		catch (System.Exception ex)
		{
			System.Windows.Forms.MessageBox.Show(text: ex.Message);

			fullNameTextBox.Focus();
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

	private void UsersDataGridView_CellDoubleClick
		(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
	{
		var selectedUser =
			usersDataGridView.Rows[e.RowIndex].DataBoundItem as
			Domain.User;

		if (selectedUser != null)
		{
			//System.Windows.Forms.MessageBox.Show(selectedUser.Username);

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
