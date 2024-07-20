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
			this.cxhToggleButton2 = new CustomUI.CXHUI.CXHToggleButton();
			this.SuspendLayout();
			// 
			// cxhToggleButton2
			// 
			this.cxhToggleButton2.AutoSize = true;
			this.cxhToggleButton2.Location = new System.Drawing.Point(448, 163);
			this.cxhToggleButton2.MinimumSize = new System.Drawing.Size(45, 22);
			this.cxhToggleButton2.Name = "cxhToggleButton2";
			this.cxhToggleButton2.OffBackColor = System.Drawing.Color.Gray;
			this.cxhToggleButton2.OffToggleColor = System.Drawing.Color.Gainsboro;
			this.cxhToggleButton2.OnBackColor = System.Drawing.Color.Gray;
			this.cxhToggleButton2.OnToggleColor = System.Drawing.Color.PaleGreen;
			this.cxhToggleButton2.Size = new System.Drawing.Size(45, 22);
			this.cxhToggleButton2.SolidStyle = false;
			this.cxhToggleButton2.TabIndex = 1;
			this.cxhToggleButton2.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1017, 561);
			this.Controls.Add(this.cxhToggleButton2);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private CXHUI.CXHButton cxhButton1;
		private CXHUI.CXHToggleButton cxhToggleButton2;
	}
}

