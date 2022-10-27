namespace MyApplication
{
	partial class LoginForm
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
			this.usernameLabel = new Dtat.Windows.Forms.Label();
			this.passwordLabel = new Dtat.Windows.Forms.Label();
			this.usernameTextBox = new Dtat.Windows.Forms.TextBox();
			this.passwordTextBox = new Dtat.Windows.Forms.TextBox();
			this.loginButton = new Dtat.Windows.Forms.Button();
			this.resetButton = new Dtat.Windows.Forms.Button();
			this.registerButton = new Dtat.Windows.Forms.Button();
			this.exitButton = new Dtat.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// usernameLabel
			// 
			this.usernameLabel.AutoSize = true;
			this.usernameLabel.Location = new System.Drawing.Point(12, 16);
			this.usernameLabel.Name = "usernameLabel";
			this.usernameLabel.Size = new System.Drawing.Size(75, 20);
			this.usernameLabel.TabIndex = 0;
			this.usernameLabel.Text = "&Username";
			// 
			// passwordLabel
			// 
			this.passwordLabel.AutoSize = true;
			this.passwordLabel.Location = new System.Drawing.Point(12, 51);
			this.passwordLabel.Name = "passwordLabel";
			this.passwordLabel.Size = new System.Drawing.Size(70, 20);
			this.passwordLabel.TabIndex = 2;
			this.passwordLabel.Text = "&Password";
			// 
			// usernameTextBox
			// 
			this.usernameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.usernameTextBox.Location = new System.Drawing.Point(93, 13);
			this.usernameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.usernameTextBox.Name = "usernameTextBox";
			this.usernameTextBox.Size = new System.Drawing.Size(393, 27);
			this.usernameTextBox.TabIndex = 1;
			// 
			// passwordTextBox
			// 
			this.passwordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.passwordTextBox.Location = new System.Drawing.Point(93, 48);
			this.passwordTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.passwordTextBox.Name = "passwordTextBox";
			this.passwordTextBox.Size = new System.Drawing.Size(393, 27);
			this.passwordTextBox.TabIndex = 3;
			this.passwordTextBox.UseSystemPasswordChar = true;
			// 
			// loginButton
			// 
			this.loginButton.Location = new System.Drawing.Point(93, 83);
			this.loginButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.loginButton.Name = "loginButton";
			this.loginButton.Size = new System.Drawing.Size(94, 29);
			this.loginButton.TabIndex = 4;
			this.loginButton.Text = "&Login";
			this.loginButton.UseVisualStyleBackColor = true;
			this.loginButton.Click += new System.EventHandler(this.LoginButton_Click);
			// 
			// resetButton
			// 
			this.resetButton.Location = new System.Drawing.Point(193, 83);
			this.resetButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.resetButton.Name = "resetButton";
			this.resetButton.Size = new System.Drawing.Size(94, 29);
			this.resetButton.TabIndex = 5;
			this.resetButton.Text = "&Reset";
			this.resetButton.UseVisualStyleBackColor = true;
			this.resetButton.Click += new System.EventHandler(this.ResetButton_Click);
			// 
			// registerButton
			// 
			this.registerButton.Location = new System.Drawing.Point(293, 83);
			this.registerButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.registerButton.Name = "registerButton";
			this.registerButton.Size = new System.Drawing.Size(94, 29);
			this.registerButton.TabIndex = 6;
			this.registerButton.Text = "Re&gister";
			this.registerButton.UseVisualStyleBackColor = true;
			this.registerButton.Click += new System.EventHandler(this.RegisterButton_Click);
			// 
			// exitButton
			// 
			this.exitButton.Location = new System.Drawing.Point(393, 83);
			this.exitButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.exitButton.Name = "exitButton";
			this.exitButton.Size = new System.Drawing.Size(94, 29);
			this.exitButton.TabIndex = 7;
			this.exitButton.Text = "E&xit";
			this.exitButton.UseVisualStyleBackColor = true;
			this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
			// 
			// LoginForm
			// 
			this.AcceptButton = this.loginButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.resetButton;
			this.ClientSize = new System.Drawing.Size(498, 125);
			this.ControlBox = false;
			this.Controls.Add(this.exitButton);
			this.Controls.Add(this.registerButton);
			this.Controls.Add(this.resetButton);
			this.Controls.Add(this.loginButton);
			this.Controls.Add(this.passwordTextBox);
			this.Controls.Add(this.usernameTextBox);
			this.Controls.Add(this.passwordLabel);
			this.Controls.Add(this.usernameLabel);
			this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this.MaximumSize = new System.Drawing.Size(800, 172);
			this.MinimumSize = new System.Drawing.Size(515, 164);
			this.Name = "LoginForm";
			this.Text = "Login";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Dtat.Windows.Forms.Label usernameLabel;
		private Dtat.Windows.Forms.Label passwordLabel;
		private Dtat.Windows.Forms.TextBox usernameTextBox;
		private Dtat.Windows.Forms.TextBox passwordTextBox;
		private Dtat.Windows.Forms.Button loginButton;
		private Dtat.Windows.Forms.Button resetButton;
		private Dtat.Windows.Forms.Button registerButton;
		private Dtat.Windows.Forms.Button exitButton;
	}
}