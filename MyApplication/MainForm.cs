using System;
using Infrastructure;
using MyApplication.Admin;
using System.Windows.Forms;

namespace MyApplication;

public partial class MainForm : Form
{
	public MainForm() : base()
	{
		InitializeComponent();
	}

	public bool IsClosing { get; set; }

	private void MainForm_Load(object sender, EventArgs e)
	{
		ResetForm();
	}

	public void ResetForm()
	{
		if (Utility.AuthenticatedUser is null)
		{
			Application.Exit();
			return;
		}

		//if (Utility.AuthenticatedUser.IsAdmin)
		//{
		//	adminToolStripMenuItem.Visible = true;
		//}
		//else
		//{
		//	adminToolStripMenuItem.Visible = false;
		//}

		adminToolStripMenuItem.Visible =
			Utility.AuthenticatedUser.IsAdmin;

		//welcomeToolStripStatusLabel.Text =
		//	$"Welcome {Utility.AuthenticatedUser.Username}";

		string? userDisplayName =
			Utility.AuthenticatedUser.FullName;

		if (string.IsNullOrWhiteSpace(value: userDisplayName))
		{
			userDisplayName =
				Utility.AuthenticatedUser.Username;
		}

		welcomeToolStripStatusLabel.Text = $"Welcome {userDisplayName}";
	}

	private ChangePasswordForm? MyChangePasswordForm { get; set; }

	private void ChangePasswordToolStripMenuItem_Click(object sender, EventArgs e)
	{
		// روش احمقانه

		//var changePasswordForm = new ChangePasswordForm();
		//changePasswordForm.MdiParent = this;
		//changePasswordForm.Show();

		// روش هوشمندانه

		if (MyChangePasswordForm is null || MyChangePasswordForm.IsDisposed)
		{
			MyChangePasswordForm = new ChangePasswordForm
			{
				MdiParent = this,
			};
		}

		MyChangePasswordForm.Show();
	}

	private UpdateProfileForm? MyUpdateProfileForm { get; set; }

	private void UpdateProfileToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (MyUpdateProfileForm is null || MyUpdateProfileForm.IsDisposed)
		{
			MyUpdateProfileForm = new UpdateProfileForm
			{
				MdiParent = this,
			};
		}

		MyUpdateProfileForm.Show();
	}

	private void LogoutToolStripMenuItem_Click(object sender, EventArgs e)
	{
		Hide();

		Utility.AuthenticatedUser = null;
		Utility.LoginForm.Show();
		Utility.LoginForm.ResetForm();
	}

	private UsersForm? MyUsersForm { get; set; }

	private void UsersToolStripMenuItem_Click(object sender, EventArgs e)
	{
		if (MyUsersForm is null || MyUsersForm.IsDisposed)
		{
			MyUsersForm = new UsersForm
			{
				MdiParent = this,
			};
		}

		MyUsersForm.Show();
	}

	private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
	{
		IsClosing = true;

		Utility.Exit();
	}

	private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
	{
		//if (IsClosing == false)
		//{
		//	// بی خیال شو - شتر دیدی ندیدی
		//	e.Cancel = true;
		//}
	}
}
