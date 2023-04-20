namespace MyApplication
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			myMenuStrip = new System.Windows.Forms.MenuStrip();
			settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			updateProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			myStatusStrip = new System.Windows.Forms.StatusStrip();
			welcomeToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			myMenuStrip.SuspendLayout();
			myStatusStrip.SuspendLayout();
			SuspendLayout();
			// 
			// myMenuStrip
			// 
			myMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
			myMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { settingsToolStripMenuItem, adminToolStripMenuItem });
			myMenuStrip.Location = new System.Drawing.Point(0, 0);
			myMenuStrip.Name = "myMenuStrip";
			myMenuStrip.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
			myMenuStrip.Size = new System.Drawing.Size(762, 30);
			myMenuStrip.TabIndex = 1;
			myMenuStrip.Text = "menuStrip1";
			// 
			// settingsToolStripMenuItem
			// 
			settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { updateProfileToolStripMenuItem, changePasswordToolStripMenuItem, toolStripMenuItem1, logoutToolStripMenuItem, exitToolStripMenuItem });
			settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
			settingsToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
			settingsToolStripMenuItem.Text = "&Settings";
			// 
			// updateProfileToolStripMenuItem
			// 
			updateProfileToolStripMenuItem.Name = "updateProfileToolStripMenuItem";
			updateProfileToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
			updateProfileToolStripMenuItem.Text = "&Update Profile";
			updateProfileToolStripMenuItem.Click += UpdateProfileToolStripMenuItem_Click;
			// 
			// changePasswordToolStripMenuItem
			// 
			changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
			changePasswordToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
			changePasswordToolStripMenuItem.Text = "&Change Password";
			changePasswordToolStripMenuItem.Click += ChangePasswordToolStripMenuItem_Click;
			// 
			// toolStripMenuItem1
			// 
			toolStripMenuItem1.Name = "toolStripMenuItem1";
			toolStripMenuItem1.Size = new System.Drawing.Size(221, 6);
			// 
			// logoutToolStripMenuItem
			// 
			logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
			logoutToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
			logoutToolStripMenuItem.Text = "&Logout";
			logoutToolStripMenuItem.Click += LogoutToolStripMenuItem_Click;
			// 
			// exitToolStripMenuItem
			// 
			exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			exitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
			exitToolStripMenuItem.Text = "E&xit";
			exitToolStripMenuItem.Click += ExitToolStripMenuItem_Click;
			// 
			// adminToolStripMenuItem
			// 
			adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { usersToolStripMenuItem });
			adminToolStripMenuItem.Name = "adminToolStripMenuItem";
			adminToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
			adminToolStripMenuItem.Text = "&Admin";
			// 
			// usersToolStripMenuItem
			// 
			usersToolStripMenuItem.Name = "usersToolStripMenuItem";
			usersToolStripMenuItem.Size = new System.Drawing.Size(127, 26);
			usersToolStripMenuItem.Text = "&Users";
			usersToolStripMenuItem.Click += UsersToolStripMenuItem_Click;
			// 
			// myStatusStrip
			// 
			myStatusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
			myStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { welcomeToolStripStatusLabel });
			myStatusStrip.Location = new System.Drawing.Point(0, 492);
			myStatusStrip.Name = "myStatusStrip";
			myStatusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
			myStatusStrip.Size = new System.Drawing.Size(762, 26);
			myStatusStrip.TabIndex = 3;
			myStatusStrip.Text = "statusStrip1";
			// 
			// welcomeToolStripStatusLabel
			// 
			welcomeToolStripStatusLabel.Name = "welcomeToolStripStatusLabel";
			welcomeToolStripStatusLabel.Size = new System.Drawing.Size(24, 20);
			welcomeToolStripStatusLabel.Text = ".....";
			// 
			// MainForm
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			ClientSize = new System.Drawing.Size(762, 518);
			Controls.Add(myStatusStrip);
			Controls.Add(myMenuStrip);
			IsMdiContainer = true;
			MainMenuStrip = myMenuStrip;
			Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			Name = "MainForm";
			StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			Text = "User Management";
			WindowState = System.Windows.Forms.FormWindowState.Maximized;
			FormClosing += MainForm_FormClosing;
			Load += MainForm_Load;
			myMenuStrip.ResumeLayout(false);
			myMenuStrip.PerformLayout();
			myStatusStrip.ResumeLayout(false);
			myStatusStrip.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private System.Windows.Forms.MenuStrip myMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem updateProfileToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
		private System.Windows.Forms.StatusStrip myStatusStrip;
		private System.Windows.Forms.ToolStripStatusLabel welcomeToolStripStatusLabel;
	}
}