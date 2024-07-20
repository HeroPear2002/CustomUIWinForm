namespace CustomUI
{
	partial class Form1
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
			this.cxhButton1 = new CustomUI.CXHUI.CXHButton();
			this.SuspendLayout();
			// 
			// cxhButton1
			// 
			this.cxhButton1.BackColor = System.Drawing.Color.MediumSlateBlue;
			this.cxhButton1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
			this.cxhButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
			this.cxhButton1.BorderRadius = 40;
			this.cxhButton1.BorderSize = 0;
			this.cxhButton1.FlatAppearance.BorderSize = 0;
			this.cxhButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cxhButton1.ForeColor = System.Drawing.Color.White;
			this.cxhButton1.Location = new System.Drawing.Point(59, 12);
			this.cxhButton1.Name = "cxhButton1";
			this.cxhButton1.Size = new System.Drawing.Size(420, 186);
			this.cxhButton1.TabIndex = 0;
			this.cxhButton1.Text = "cxhButton1";
			this.cxhButton1.TextColor = System.Drawing.Color.MediumSlateBlue;
			this.cxhButton1.UseVisualStyleBackColor = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(632, 278);
			this.Controls.Add(this.cxhButton1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private CXHUI.CXHButton cxhButton1;
	}
}

