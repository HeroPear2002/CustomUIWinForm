using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CustomUI
{
	public partial class Form1 : DevExpress.XtraEditors.XtraForm
	{
		public Form1()
		{
			InitializeComponent();
			MessageBox.Show(cxhButton2.BorderRadius.ToString());
		}
	}
}
