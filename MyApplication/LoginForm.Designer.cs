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
			this.usernameLabel.Location = new System.Drawing.Point(12, 15);
			this.usernameLabel.Name = "usernameLabel";
			this.usernameLabel.Size = new System.Drawing.Size(60, 15);
			this.usernameLabel.TabIndex = 0;
			this.usernameLabel.Text = "&Username";
			// 
			// passwordLabel
			// 
			this.passwordLabel.AutoSize = true;
			this.passwordLabel.Location = new System.Drawing.Point(12, 44);
			this.passwordLabel.Name = "passwordLabel";
			this.passwordLabel.Size = new System.Drawing.Size(57, 15);
			this.passwordLabel.TabIndex = 2;
			this.passwordLabel.Text = "&Password";
			// 
			// usernameTextBox
			// 
			this.usernameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.usernameTextBox.Location = new System.Drawing.Point(78, 12);
			this.usernameTextBox.Name = "usernameTextBox";
			this.usernameTextBox.Size = new System.Drawing.Size(317, 23);
			this.usernameTextBox.TabIndex = 1;
			// 
			// passwordTextBox
			// 
			this.passwordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.passwordTextBox.Location = new System.Drawing.Point(78, 41);
			this.passwordTextBox.Name = "passwordTextBox";
			this.passwordTextBox.Size = new System.Drawing.Size(317, 23);
			this.passwordTextBox.TabIndex = 3;
			this.passwordTextBox.UseSystemPasswordChar = true;
			// 
			// loginButton
			// 
			this.loginButton.Location = new System.Drawing.Point(78, 70);
			this.loginButton.Name = "loginButton";
			this.loginButton.Size = new System.Drawing.Size(75, 23);
			this.loginButton.TabIndex = 4;
			this.loginButton.Text = "&Login";
			this.loginButton.UseVisualStyleBackColor = true;
			this.loginButton.Click += new System.EventHandler(this.LoginButton_Click);
			// 
			// resetButton
			// 
			this.resetButton.Location = new System.Drawing.Point(159, 70);
			this.resetButton.Name = "resetButton";
			this.resetButton.Size = new System.Drawing.Size(75, 23);
			this.resetButton.TabIndex = 5;
			this.resetButton.Text = "&Reset";
			this.resetButton.UseVisualStyleBackColor = true;
			this.resetButton.Click += new System.EventHandler(this.ResetButton_Click);
			// 
			// registerButton
			// 
			this.registerButton.Location = new System.Drawing.Point(240, 70);
			this.registerButton.Name = "registerButton";
			this.registerButton.Size = new System.Drawing.Size(75, 23);
			this.registerButton.TabIndex = 6;
			this.registerButton.Text = "Re&gister";
			this.registerButton.UseVisualStyleBackColor = true;
			this.registerButton.Click += new System.EventHandler(this.RegisterButton_Click);
			// 
			// exitButton
			// 
			this.exitButton.Location = new System.Drawing.Point(321, 70);
			this.exitButton.Name = "exitButton";
			this.exitButton.Size = new System.Drawing.Size(75, 23);
			this.exitButton.TabIndex = 7;
			this.exitButton.Text = "E&xit";
			this.exitButton.UseVisualStyleBackColor = true;
			this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
			// 
			// LoginForm
			// 
			this.AcceptButton = this.loginButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.resetButton;
			this.ClientSize = new System.Drawing.Size(407, 103);
			this.ControlBox = false;
			this.Controls.Add(this.exitButton);
			this.Controls.Add(this.registerButton);
			this.Controls.Add(this.resetButton);
			this.Controls.Add(this.loginButton);
			this.Controls.Add(this.passwordTextBox);
			this.Controls.Add(this.usernameTextBox);
			this.Controls.Add(this.passwordLabel);
			this.Controls.Add(this.usernameLabel);
			this.MaximumSize = new System.Drawing.Size(800, 142);
			this.MinimumSize = new System.Drawing.Size(423, 142);
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