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
	public partial class SetSeed : Form
	{

		Form1 f;

		public SetSeed(Form1 m)
		{
			InitializeComponent();
			this.SEDD.Value = ABC_lib_01.real_seed;
			this.f = m;
		}

		private void SetSdreal_seed_Click(object sender, EventArgs e)
		{
			ABC_lib_01.real_seed = (int)this.SEDD.Value;
			this.f.toolStripTextBox1.Text = ABC_lib_01.real_seed.ToString();
			this.Close();
		}
	}
}
