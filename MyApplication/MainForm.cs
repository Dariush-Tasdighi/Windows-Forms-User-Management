namespace MyApplication;

public partial class MainForm : System.Windows.Forms.Form
{
	public MainForm() : base()
	{
		InitializeComponent();
	}

	private void MainForm_Load(object sender, System.EventArgs e)
	{
		ResetForm();
	}

	public void ResetForm()
	{
		if (Infrastructure.Utility.AuthenticatedUser == null)
		{
			System.Windows.Forms.Application.Exit();
			return;
		}

		//if (Infrastructure.Utility.AuthenticatedUser.IsAdmin)
		//{
		//	adminToolStripMenuItem.Visible = true;
		//}
		//else
		//{
		//	adminToolStripMenuItem.Visible = false;
		//}

		adminToolStripMenuItem.Visible =
			Infrastructure.Utility.AuthenticatedUser.IsAdmin;

		//welcomeToolStripStatusLabel.Text =
		//	$"Welcome {Infrastructure.Utility.AuthenticatedUser!.Username}";

		string? userDisplayName =
			Infrastructure.Utility.AuthenticatedUser.FullName;

		if (string.IsNullOrWhiteSpace(value: userDisplayName))
		{
			userDisplayName =
				Infrastructure.Utility.AuthenticatedUser.Username;
		}

		welcomeToolStripStatusLabel.Text = $"Welcome {userDisplayName}";
	}

	private ChangePasswordForm? MyChangePasswordForm { get; set; }

	private void ChangePasswordToolStripMenuItem_Click(object sender, System.EventArgs e)
	{
		// روش احمقانه

		//var changePasswordForm = new ChangePasswordForm();
		//changePasswordForm.MdiParent = this;
		//changePasswordForm.Show();

		// روش هوشمندانه

		if (MyChangePasswordForm == null || MyChangePasswordForm.IsDisposed)
		{
			MyChangePasswordForm = new ChangePasswordForm
			{
				MdiParent = this,
			};
		}

		MyChangePasswordForm.Show();
	}

	private UpdateProfileForm? MyUpdateProfileForm { get; set; }

	private void UpdateProfileToolStripMenuItem_Click(object sender, System.EventArgs e)
	{
		if (MyUpdateProfileForm == null || MyUpdateProfileForm.IsDisposed)
		{
			MyUpdateProfileForm = new UpdateProfileForm
			{
				MdiParent = this,
			};
		}

		MyUpdateProfileForm.Show();
	}

	private void LogoutToolStripMenuItem_Click(object sender, System.EventArgs e)
	{
		Hide();

		Infrastructure.Utility.AuthenticatedUser = null;
		Infrastructure.Utility.LoginForm.Show();
		Infrastructure.Utility.LoginForm.ResetForm();
	}

	private void ExitToolStripMenuItem_Click(object sender, System.EventArgs e)
	{
		//var result =
		//	System.Windows.Forms.MessageBox.Show("");

		System.Windows.Forms.Application.Exit();
	}

	private Admin.UsersForm? MyUsersForm { get; set; }

	private void UsersToolStripMenuItem_Click(object sender, System.EventArgs e)
	{
		if (MyUsersForm == null || MyUsersForm.IsDisposed)
		{
			MyUsersForm = new Admin.UsersForm
			{
				MdiParent = this,
			};
		}

		MyUsersForm.Show();
	}
}
