using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MappingResources
{
	public partial class SizeIcon : Form
	{
		private Resource reees;
		public SizeIcon(Resource r, int x, int y)
		{
			InitializeComponent();
			this.reees = r;
			this.numericUpDown1.Value = x;
			this.numericUpDown2.Value = y;
		}

		private void OK_but_Click(object sender, EventArgs e)
		{
			reees.numericUpDown1.Value = this.numericUpDown1.Value;
			reees.numericUpDown2.Value = this.numericUpDown2.Value;
			reees.SetIcon();
			this.Close();
		}
	}
}
