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
			this.cxhButton2 = new CustomUI.CXHUI.CXHButton();
			this.SuspendLayout();
			// 
			// cxhButton2
			// 
			this.cxhButton2.BackColor = System.Drawing.Color.MediumSlateBlue;
			this.cxhButton2.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
			this.cxhButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
			this.cxhButton2.BorderRadius = 100;
			this.cxhButton2.BorderSize = 0;
			this.cxhButton2.FlatAppearance.BorderSize = 0;
			this.cxhButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cxhButton2.ForeColor = System.Drawing.Color.White;
			this.cxhButton2.Location = new System.Drawing.Point(171, 54);
			this.cxhButton2.Name = "cxhButton2";
			this.cxhButton2.Size = new System.Drawing.Size(244, 152);
			this.cxhButton2.TabIndex = 0;
			this.cxhButton2.Text = "cxhButton2";
			this.cxhButton2.TextColor = System.Drawing.Color.MediumSlateBlue;
			this.cxhButton2.UseVisualStyleBackColor = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(632, 278);
			this.Controls.Add(this.cxhButton2);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private CXHUI.CXHButton cxhButton1;
		private CXHUI.CXHButton cxhButton2;
	}
}

