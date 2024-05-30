namespace Infrastructure;

partial class BaseForm
{
	private System.ComponentModel.IContainer components = null;

	protected override void Dispose(bool disposing)
	{
		if (disposing && (components != null))
		{
			components.Dispose();
		}

		base.Dispose(disposing);
	}

	#region Windows Form Designer generated code

	private void InitializeComponent()
	{
		this.SuspendLayout();
		// 
		// BaseForm
		// 
		this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
		this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.ClientSize = new System.Drawing.Size(398, 384);
		this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		this.Name = "BaseForm";
		this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.ResumeLayout(false);

	}

	#endregion
}
