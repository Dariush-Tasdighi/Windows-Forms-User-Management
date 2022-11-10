namespace MyApplication.Admin
{
	partial class UsersForm
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
			this.topPanel = new Dtat.Windows.Forms.Panel();
			this.searchButton = new Dtat.Windows.Forms.Button();
			this.fullNameLabel = new Dtat.Windows.Forms.Label();
			this.fullNameTextBox = new Dtat.Windows.Forms.TextBox();
			this.mainPanel = new Dtat.Windows.Forms.Panel();
			this.usersDataGridView = new Dtat.Windows.Forms.DataGridView();
			this.topPanel.SuspendLayout();
			this.mainPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.usersDataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// topPanel
			// 
			this.topPanel.Controls.Add(this.searchButton);
			this.topPanel.Controls.Add(this.fullNameLabel);
			this.topPanel.Controls.Add(this.fullNameTextBox);
			this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.topPanel.Location = new System.Drawing.Point(0, 0);
			this.topPanel.Name = "topPanel";
			this.topPanel.Size = new System.Drawing.Size(673, 85);
			this.topPanel.TabIndex = 0;
			// 
			// searchButton
			// 
			this.searchButton.Location = new System.Drawing.Point(94, 45);
			this.searchButton.Name = "searchButton";
			this.searchButton.Size = new System.Drawing.Size(94, 29);
			this.searchButton.TabIndex = 2;
			this.searchButton.Text = "&Search";
			this.searchButton.UseVisualStyleBackColor = true;
			this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
			// 
			// fullNameLabel
			// 
			this.fullNameLabel.AutoSize = true;
			this.fullNameLabel.Location = new System.Drawing.Point(12, 15);
			this.fullNameLabel.Name = "fullNameLabel";
			this.fullNameLabel.Size = new System.Drawing.Size(76, 20);
			this.fullNameLabel.TabIndex = 0;
			this.fullNameLabel.Text = "&Full Name";
			// 
			// fullNameTextBox
			// 
			this.fullNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.fullNameTextBox.Location = new System.Drawing.Point(94, 12);
			this.fullNameTextBox.Name = "fullNameTextBox";
			this.fullNameTextBox.Size = new System.Drawing.Size(567, 27);
			this.fullNameTextBox.TabIndex = 1;
			// 
			// mainPanel
			// 
			this.mainPanel.Controls.Add(this.usersDataGridView);
			this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainPanel.Location = new System.Drawing.Point(0, 85);
			this.mainPanel.Name = "mainPanel";
			this.mainPanel.Size = new System.Drawing.Size(673, 327);
			this.mainPanel.TabIndex = 1;
			// 
			// usersDataGridView
			// 
			this.usersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.usersDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.usersDataGridView.Location = new System.Drawing.Point(0, 0);
			this.usersDataGridView.Name = "usersDataGridView";
			this.usersDataGridView.RowHeadersWidth = 51;
			this.usersDataGridView.RowTemplate.Height = 29;
			this.usersDataGridView.Size = new System.Drawing.Size(673, 327);
			this.usersDataGridView.TabIndex = 0;
			this.usersDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UsersDataGridView_CellDoubleClick);
			// 
			// UsersForm
			// 
			this.AcceptButton = this.searchButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(673, 412);
			this.Controls.Add(this.mainPanel);
			this.Controls.Add(this.topPanel);
			this.Name = "UsersForm";
			this.Text = "Users";
			this.Load += new System.EventHandler(this.UsersForm_Load);
			this.topPanel.ResumeLayout(false);
			this.topPanel.PerformLayout();
			this.mainPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.usersDataGridView)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Dtat.Windows.Forms.Panel topPanel;
		private Dtat.Windows.Forms.Panel bottomPanel;
		private Dtat.Windows.Forms.Panel mainPanel;
		private Dtat.Windows.Forms.DataGridView usersDataGridView;
		private Dtat.Windows.Forms.Button searchButton;
		private Dtat.Windows.Forms.Label fullNameLabel;
		private Dtat.Windows.Forms.TextBox fullNameTextBox;
	}
}