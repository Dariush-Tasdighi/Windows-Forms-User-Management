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
			welcomeToolStripStatusLabel.Text =
				$"Welcome {Infrastructure.Utility.AuthenticatedUser!.Username}";
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
	}
}
