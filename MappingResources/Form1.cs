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
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			generateSeed();
		}




		// - выход
		private void Close_programm_ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void New_Map_ToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		private void Save_Map_ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			
		}

		private void Open_Map_ToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void SeedToolStripMenuItem_Click(object sender, EventArgs e)
		{
			generateSeed();
		}

		private void toolStripTextBox1_Click(object sender, EventArgs e)
		{
			SetSeed ss = new SetSeed(this);
			ss.Show();
		}

		void generateSeed() {
			ABC_lib_01.real_seed = ABC_lib_01.r.Next(int.MinValue, int.MaxValue);
			ABC_lib_01.random = new Random(ABC_lib_01.real_seed);
			this.toolStripTextBox1.Text = ABC_lib_01.real_seed.ToString();
		}
	}
}
