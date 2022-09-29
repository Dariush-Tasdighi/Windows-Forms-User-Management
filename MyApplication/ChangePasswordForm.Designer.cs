namespace MyApplication
{
	partial class ChangePasswordForm
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
			this.oldPasswordLabel = new Dtat.Windows.Forms.Label();
			this.newPasswordLabel = new Dtat.Windows.Forms.Label();
			this.confirmNewPasswordLabel = new Dtat.Windows.Forms.Label();
			this.oldPasswordTextBox = new Dtat.Windows.Forms.TextBox();
			this.newPasswordTextBox = new Dtat.Windows.Forms.TextBox();
			this.confirmNewPasswordTextBox = new Dtat.Windows.Forms.TextBox();
			this.changePasswordButton = new Dtat.Windows.Forms.Button();
			this.resetButton = new Dtat.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// oldPasswordLabel
			// 
			this.oldPasswordLabel.AutoSize = true;
			this.oldPasswordLabel.Location = new System.Drawing.Point(12, 15);
			this.oldPasswordLabel.Name = "oldPasswordLabel";
			this.oldPasswordLabel.Size = new System.Drawing.Size(79, 15);
			this.oldPasswordLabel.TabIndex = 0;
			this.oldPasswordLabel.Text = "&Old Password";
			// 
			// newPasswordLabel
			// 
			this.newPasswordLabel.AutoSize = true;
			this.newPasswordLabel.Location = new System.Drawing.Point(12, 44);
			this.newPasswordLabel.Name = "newPasswordLabel";
			this.newPasswordLabel.Size = new System.Drawing.Size(84, 15);
			this.newPasswordLabel.TabIndex = 2;
			this.newPasswordLabel.Text = "&New Password";
			// 
			// confirmNewPasswordLabel
			// 
			this.confirmNewPasswordLabel.AutoSize = true;
			this.confirmNewPasswordLabel.Location = new System.Drawing.Point(12, 73);
			this.confirmNewPasswordLabel.Name = "confirmNewPasswordLabel";
			this.confirmNewPasswordLabel.Size = new System.Drawing.Size(131, 15);
			this.confirmNewPasswordLabel.TabIndex = 4;
			this.confirmNewPasswordLabel.Text = "&Confirm New Password";
			// 
			// oldPasswordTextBox
			// 
			this.oldPasswordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.oldPasswordTextBox.Location = new System.Drawing.Point(149, 12);
			this.oldPasswordTextBox.MaxLength = 20;
			this.oldPasswordTextBox.Name = "oldPasswordTextBox";
			this.oldPasswordTextBox.Size = new System.Drawing.Size(342, 23);
			this.oldPasswordTextBox.TabIndex = 1;
			this.oldPasswordTextBox.UseSystemPasswordChar = true;
			// 
			// newPasswordTextBox
			// 
			this.newPasswordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.newPasswordTextBox.Location = new System.Drawing.Point(149, 41);
			this.newPasswordTextBox.MaxLength = 20;
			this.newPasswordTextBox.Name = "newPasswordTextBox";
			this.newPasswordTextBox.Size = new System.Drawing.Size(342, 23);
			this.newPasswordTextBox.TabIndex = 3;
			this.newPasswordTextBox.UseSystemPasswordChar = true;
			// 
			// confirmNewPasswordTextBox
			// 
			this.confirmNewPasswordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.confirmNewPasswordTextBox.Location = new System.Drawing.Point(149, 70);
			this.confirmNewPasswordTextBox.MaxLength = 20;
			this.confirmNewPasswordTextBox.Name = "confirmNewPasswordTextBox";
			this.confirmNewPasswordTextBox.Size = new System.Drawing.Size(342, 23);
			this.confirmNewPasswordTextBox.TabIndex = 5;
			this.confirmNewPasswordTextBox.UseSystemPasswordChar = true;
			// 
			// changePasswordButton
			// 
			this.changePasswordButton.Location = new System.Drawing.Point(149, 99);
			this.changePasswordButton.Name = "changePasswordButton";
			this.changePasswordButton.Size = new System.Drawing.Size(123, 23);
			this.changePasswordButton.TabIndex = 6;
			this.changePasswordButton.Text = "Change &Password";
			this.changePasswordButton.UseVisualStyleBackColor = true;
			this.changePasswordButton.Click += new System.EventHandler(this.ChangePasswordButton_Click);
			// 
			// resetButton
			// 
			this.resetButton.Location = new System.Drawing.Point(278, 99);
			this.resetButton.Name = "resetButton";
			this.resetButton.Size = new System.Drawing.Size(123, 23);
			this.resetButton.TabIndex = 7;
			this.resetButton.Text = "&Reset";
			this.resetButton.UseVisualStyleBackColor = true;
			this.resetButton.Click += new System.EventHandler(this.ResetButton_Click);
			// 
			// ChangePasswordForm
			// 
			this.AcceptButton = this.changePasswordButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.resetButton;
			this.ClientSize = new System.Drawing.Size(503, 130);
			this.Controls.Add(this.resetButton);
			this.Controls.Add(this.changePasswordButton);
			this.Controls.Add(this.confirmNewPasswordTextBox);
			this.Controls.Add(this.newPasswordTextBox);
			this.Controls.Add(this.oldPasswordTextBox);
			this.Controls.Add(this.confirmNewPasswordLabel);
			this.Controls.Add(this.newPasswordLabel);
			this.Controls.Add(this.oldPasswordLabel);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ChangePasswordForm";
			this.Text = "Change Password";
			this.Load += new System.EventHandler(this.ChangePasswordForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Dtat.Windows.Forms.Label oldPasswordLabel;
		private Dtat.Windows.Forms.Label newPasswordLabel;
		private Dtat.Windows.Forms.Label confirmNewPasswordLabel;
		private Dtat.Windows.Forms.TextBox oldPasswordTextBox;
		private Dtat.Windows.Forms.TextBox newPasswordTextBox;
		private Dtat.Windows.Forms.TextBox confirmNewPasswordTextBox;
		private Dtat.Windows.Forms.Button changePasswordButton;
		private Dtat.Windows.Forms.Button resetButton;
	}
}