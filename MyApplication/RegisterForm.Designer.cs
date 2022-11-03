namespace MyApplication
{
	partial class RegisterForm
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
			this.exitButton = new Dtat.Windows.Forms.Button();
			this.registerButton = new Dtat.Windows.Forms.Button();
			this.resetButton = new Dtat.Windows.Forms.Button();
			this.loginButton = new Dtat.Windows.Forms.Button();
			this.passwordTextBox = new Dtat.Windows.Forms.TextBox();
			this.usernameTextBox = new Dtat.Windows.Forms.TextBox();
			this.passwordLabel = new Dtat.Windows.Forms.Label();
			this.usernameLabel = new Dtat.Windows.Forms.Label();
			this.fullNameLabel = new Dtat.Windows.Forms.Label();
			this.fullNameTextBox = new Dtat.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// exitButton
			// 
			this.exitButton.Location = new System.Drawing.Point(394, 116);
			this.exitButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.exitButton.Name = "exitButton";
			this.exitButton.Size = new System.Drawing.Size(94, 29);
			this.exitButton.TabIndex = 9;
			this.exitButton.Text = "E&xit";
			this.exitButton.UseVisualStyleBackColor = true;
			// 
			// registerButton
			// 
			this.registerButton.Location = new System.Drawing.Point(94, 116);
			this.registerButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.registerButton.Name = "registerButton";
			this.registerButton.Size = new System.Drawing.Size(94, 29);
			this.registerButton.TabIndex = 6;
			this.registerButton.Text = "Re&gister";
			this.registerButton.UseVisualStyleBackColor = true;
			this.registerButton.Click += new System.EventHandler(this.RegisterButton_Click);
			// 
			// resetButton
			// 
			this.resetButton.Location = new System.Drawing.Point(194, 116);
			this.resetButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.resetButton.Name = "resetButton";
			this.resetButton.Size = new System.Drawing.Size(94, 29);
			this.resetButton.TabIndex = 7;
			this.resetButton.Text = "&Reset";
			this.resetButton.UseVisualStyleBackColor = true;
			this.resetButton.Click += new System.EventHandler(this.ResetButton_Click);
			// 
			// loginButton
			// 
			this.loginButton.Location = new System.Drawing.Point(294, 116);
			this.loginButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.loginButton.Name = "loginButton";
			this.loginButton.Size = new System.Drawing.Size(94, 29);
			this.loginButton.TabIndex = 8;
			this.loginButton.Text = "&Login";
			this.loginButton.UseVisualStyleBackColor = true;
			this.loginButton.Click += new System.EventHandler(this.LoginButton_Click);
			// 
			// passwordTextBox
			// 
			this.passwordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.passwordTextBox.Location = new System.Drawing.Point(94, 48);
			this.passwordTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.passwordTextBox.MaxLength = 20;
			this.passwordTextBox.Name = "passwordTextBox";
			this.passwordTextBox.Size = new System.Drawing.Size(393, 27);
			this.passwordTextBox.TabIndex = 3;
			this.passwordTextBox.UseSystemPasswordChar = true;
			// 
			// usernameTextBox
			// 
			this.usernameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.usernameTextBox.Location = new System.Drawing.Point(94, 13);
			this.usernameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.usernameTextBox.MaxLength = 20;
			this.usernameTextBox.Name = "usernameTextBox";
			this.usernameTextBox.Size = new System.Drawing.Size(393, 27);
			this.usernameTextBox.TabIndex = 1;
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
			// usernameLabel
			// 
			this.usernameLabel.AutoSize = true;
			this.usernameLabel.Location = new System.Drawing.Point(12, 16);
			this.usernameLabel.Name = "usernameLabel";
			this.usernameLabel.Size = new System.Drawing.Size(75, 20);
			this.usernameLabel.TabIndex = 0;
			this.usernameLabel.Text = "&Username";
			// 
			// fullNameLabel
			// 
			this.fullNameLabel.AutoSize = true;
			this.fullNameLabel.Location = new System.Drawing.Point(12, 85);
			this.fullNameLabel.Name = "fullNameLabel";
			this.fullNameLabel.Size = new System.Drawing.Size(76, 20);
			this.fullNameLabel.TabIndex = 4;
			this.fullNameLabel.Text = "&Full Name";
			// 
			// fullNameTextBox
			// 
			this.fullNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.fullNameTextBox.Location = new System.Drawing.Point(94, 82);
			this.fullNameTextBox.MaxLength = 50;
			this.fullNameTextBox.Name = "fullNameTextBox";
			this.fullNameTextBox.Size = new System.Drawing.Size(393, 27);
			this.fullNameTextBox.TabIndex = 5;
			// 
			// RegisterForm
			// 
			this.AcceptButton = this.registerButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.resetButton;
			this.ClientSize = new System.Drawing.Size(499, 157);
			this.ControlBox = false;
			this.Controls.Add(this.fullNameTextBox);
			this.Controls.Add(this.fullNameLabel);
			this.Controls.Add(this.exitButton);
			this.Controls.Add(this.registerButton);
			this.Controls.Add(this.resetButton);
			this.Controls.Add(this.loginButton);
			this.Controls.Add(this.passwordTextBox);
			this.Controls.Add(this.usernameTextBox);
			this.Controls.Add(this.passwordLabel);
			this.Controls.Add(this.usernameLabel);
			this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this.MaximumSize = new System.Drawing.Size(800, 204);
			this.MinimumSize = new System.Drawing.Size(517, 204);
			this.Name = "RegisterForm";
			this.Text = "Register";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Dtat.Windows.Forms.Button exitButton;
		private Dtat.Windows.Forms.Button registerButton;
		private Dtat.Windows.Forms.Button resetButton;
		private Dtat.Windows.Forms.Button loginButton;
		private Dtat.Windows.Forms.TextBox passwordTextBox;
		private Dtat.Windows.Forms.TextBox usernameTextBox;
		private Dtat.Windows.Forms.Label passwordLabel;
		private Dtat.Windows.Forms.Label usernameLabel;
		private Dtat.Windows.Forms.Label fullNameLabel;
		private Dtat.Windows.Forms.TextBox fullNameTextBox;
	}
}