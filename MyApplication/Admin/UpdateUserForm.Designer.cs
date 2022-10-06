namespace MyApplication.Admin
{
	partial class UpdateUserForm
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
			this.fullNameTextBox = new Dtat.Windows.Forms.TextBox();
			this.descriptionTextBox = new Dtat.Windows.Forms.TextBox();
			this.fullNameLabel = new Dtat.Windows.Forms.Label();
			this.descriptionLabel = new Dtat.Windows.Forms.Label();
			this.isActiveCheckBox = new Dtat.Windows.Forms.CheckBox();
			this.isAdminCheckBox = new Dtat.Windows.Forms.CheckBox();
			this.updateButton = new Dtat.Windows.Forms.Button();
			this.resetButton = new Dtat.Windows.Forms.Button();
			this.deleteButton = new Dtat.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// fullNameTextBox
			// 
			this.fullNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.fullNameTextBox.Location = new System.Drawing.Point(103, 12);
			this.fullNameTextBox.Name = "fullNameTextBox";
			this.fullNameTextBox.Size = new System.Drawing.Size(474, 27);
			this.fullNameTextBox.TabIndex = 0;
			// 
			// descriptionTextBox
			// 
			this.descriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.descriptionTextBox.Location = new System.Drawing.Point(103, 45);
			this.descriptionTextBox.Multiline = true;
			this.descriptionTextBox.Name = "descriptionTextBox";
			this.descriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.descriptionTextBox.Size = new System.Drawing.Size(474, 151);
			this.descriptionTextBox.TabIndex = 1;
			// 
			// fullNameLabel
			// 
			this.fullNameLabel.AutoSize = true;
			this.fullNameLabel.Location = new System.Drawing.Point(12, 15);
			this.fullNameLabel.Name = "fullNameLabel";
			this.fullNameLabel.Size = new System.Drawing.Size(76, 20);
			this.fullNameLabel.TabIndex = 3;
			this.fullNameLabel.Text = "&Full Name";
			// 
			// descriptionLabel
			// 
			this.descriptionLabel.AutoSize = true;
			this.descriptionLabel.Location = new System.Drawing.Point(12, 48);
			this.descriptionLabel.Name = "descriptionLabel";
			this.descriptionLabel.Size = new System.Drawing.Size(85, 20);
			this.descriptionLabel.TabIndex = 4;
			this.descriptionLabel.Text = "&Description";
			// 
			// isActiveCheckBox
			// 
			this.isActiveCheckBox.AutoSize = true;
			this.isActiveCheckBox.Location = new System.Drawing.Point(103, 202);
			this.isActiveCheckBox.Name = "isActiveCheckBox";
			this.isActiveCheckBox.Size = new System.Drawing.Size(72, 24);
			this.isActiveCheckBox.TabIndex = 6;
			this.isActiveCheckBox.Text = "Active";
			this.isActiveCheckBox.UseVisualStyleBackColor = true;
			// 
			// isAdminCheckBox
			// 
			this.isAdminCheckBox.AutoSize = true;
			this.isAdminCheckBox.Location = new System.Drawing.Point(103, 232);
			this.isAdminCheckBox.Name = "isAdminCheckBox";
			this.isAdminCheckBox.Size = new System.Drawing.Size(75, 24);
			this.isAdminCheckBox.TabIndex = 7;
			this.isAdminCheckBox.Text = "Admin";
			this.isAdminCheckBox.UseVisualStyleBackColor = true;
			// 
			// updateButton
			// 
			this.updateButton.Location = new System.Drawing.Point(103, 262);
			this.updateButton.Name = "updateButton";
			this.updateButton.Size = new System.Drawing.Size(94, 29);
			this.updateButton.TabIndex = 8;
			this.updateButton.Text = "&Update";
			this.updateButton.UseVisualStyleBackColor = true;
			this.updateButton.Click += new System.EventHandler(this.UpdateButton_Click);
			// 
			// resetButton
			// 
			this.resetButton.Location = new System.Drawing.Point(203, 262);
			this.resetButton.Name = "resetButton";
			this.resetButton.Size = new System.Drawing.Size(94, 29);
			this.resetButton.TabIndex = 9;
			this.resetButton.Text = "&Reset";
			this.resetButton.UseVisualStyleBackColor = true;
			this.resetButton.Click += new System.EventHandler(this.ResetButton_Click);
			// 
			// deleteButton
			// 
			this.deleteButton.BackColor = System.Drawing.Color.LightCoral;
			this.deleteButton.Location = new System.Drawing.Point(303, 262);
			this.deleteButton.Name = "deleteButton";
			this.deleteButton.Size = new System.Drawing.Size(94, 29);
			this.deleteButton.TabIndex = 10;
			this.deleteButton.Text = "De&lete";
			this.deleteButton.UseVisualStyleBackColor = false;
			this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
			// 
			// UpdateUserForm
			// 
			this.AcceptButton = this.updateButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.resetButton;
			this.ClientSize = new System.Drawing.Size(589, 305);
			this.Controls.Add(this.deleteButton);
			this.Controls.Add(this.resetButton);
			this.Controls.Add(this.updateButton);
			this.Controls.Add(this.isAdminCheckBox);
			this.Controls.Add(this.isActiveCheckBox);
			this.Controls.Add(this.descriptionLabel);
			this.Controls.Add(this.fullNameLabel);
			this.Controls.Add(this.descriptionTextBox);
			this.Controls.Add(this.fullNameTextBox);
			this.Name = "UpdateUserForm";
			this.Text = "Update User";
			this.Load += new System.EventHandler(this.UpdateUserForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Dtat.Windows.Forms.TextBox fullNameTextBox;
		private Dtat.Windows.Forms.TextBox descriptionTextBox;
		private Dtat.Windows.Forms.Label fullNameLabel;
		private Dtat.Windows.Forms.Label descriptionLabel;
		private Dtat.Windows.Forms.CheckBox isActiveCheckBox;
		private Dtat.Windows.Forms.CheckBox isAdminCheckBox;
		private Dtat.Windows.Forms.Button updateButton;
		private Dtat.Windows.Forms.Button resetButton;
		private Dtat.Windows.Forms.Button deleteButton;
	}
}