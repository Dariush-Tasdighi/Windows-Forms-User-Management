namespace MyApplication
{
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
	}
}
