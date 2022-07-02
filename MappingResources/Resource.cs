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
	public partial class Resource : UserControl
	{
		Dictionary<TextBox, string> d = new Dictionary<TextBox, string>();
		public Form1 fm1;
		Bitmap icon;
		private int pic_x, pic_y;

		public Resource(Form1 f)
		{
			InitializeComponent();
			d.Add(this.name_res, "Название ресурса");
			sizeSet("▲");
			InitFierld();
			this.Resource_icon.Image = new Bitmap(50,50);
			this.fm1 = f;
		}

		private void InitFierld() {
			TextBoxChangeText(this.name_res, d[this.name_res], true);
		}


		private void inputGotFocus(object sender, EventArgs e)
		{
			TextBoxChangeText(((TextBox)sender), d[((TextBox)sender)], false);
		}

		private void inputLostFocus(object sender, EventArgs e)
		{
			TextBoxChangeText(((TextBox)sender), d[((TextBox)sender)], true);
		}

		private void pic_click(object sender, EventArgs e)
		{
			this.ofd.Title = "Открыть иконку ресурсов";
			this.ofd.Filter = ABC_lib_01.fileFormat_img;
			if (this.ofd.ShowDialog() == DialogResult.OK)
			{
				this.icon = new Bitmap(ofd.FileName);
				SetIcon(this.icon);
			}
		}

		public void SetIcon(Bitmap b) {
			this.pic_x = (int)this.numericUpDown1.Value / 2;
			this.pic_y = (int)this.numericUpDown2.Value / 2;
			this.Resource_icon.Image = new Bitmap(b, new Size((int)this.numericUpDown1.Value, (int)this.numericUpDown2.Value));
		}
		public void SetIcon() {
			this.SetIcon(this.icon);
		}

		private void valueSizeChange(object sender, EventArgs e) {
			SizeIcon si = new SizeIcon(this, (int)this.numericUpDown1.Value, (int)this.numericUpDown2.Value);
			si.Show();
		}


		private void TextBoxChangeText(TextBox sender, string nullText, bool Lost) {
			if (Lost) {
				sender.BackColor = SystemColors.Control;
				sender.BorderStyle = BorderStyle.None;
				if (sender.Text == "")
				{
					sender.Font = new Font(sender.Font, FontStyle.Italic);
					sender.Text = nullText;
				}
				else
				{
					sender.Font = new Font(sender.Font, FontStyle.Bold);
				}
			} else {
				sender.BackColor = Color.White;
				sender.BorderStyle = BorderStyle.FixedSingle;
				if (sender.Font.Italic)
				{
					sender.Font = new Font(sender.Font, FontStyle.Regular);
					sender.Text = "";
				}
			}
		}

		private void Reset_Click(object sender, EventArgs e)
		{
			this.coordinates.Controls.Clear();
			for(int i=0; i<this.countRess.Value; i++) {
				XYcoor c = new XYcoor();
				c.Dock = DockStyle.Top;
				this.coordinates.Controls.Add(c);
			}
		}

		private void UpDown_Click(object sender, EventArgs e) {
			if (this.UpDown.Text == "▼") {
				sizeSet("▲");
				return;
			}
			if (this.UpDown.Text == "▲")
			{
				sizeSet("▼");
				return;
			}
		}

		void sizeSet(string s) {
			if (s == "▼")
			{
				this.coordinates.Size = new System.Drawing.Size(250, 174);
				this.Size = new System.Drawing.Size(250, 279);
				this.UpDown.Text = "▼";
			}
			if (s == "▲")
			{
				this.coordinates.Size = new System.Drawing.Size(250, 0);
				this.Size = new System.Drawing.Size(250, 105);
				this.UpDown.Text = "▲";
			}
		}

		private void delete_button_Click(object sender, EventArgs e)
		{
			this.fm1.deleteRes(this);
		}

		public bool inRes(int x, int y, XYcoor xyc)
		{
			return (x >= xyc.Xcoor.Value - this.pic_x && x < xyc.Xcoor.Value + this.numericUpDown1.Value - this.pic_x &&
				 y >= xyc.Ycoor.Value - this.pic_y && y < xyc.Ycoor.Value + this.numericUpDown2.Value - this.pic_y);
		}

		public Color getColor (int x, int y, XYcoor xyc) {
			return (this.Resource_icon.Image as Bitmap).GetPixel(x - (int)xyc.Xcoor.Value + pic_x, y - (int)xyc.Ycoor.Value + pic_y);
		}
	}
}
