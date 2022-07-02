using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using System.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MappingResources
{
	public partial class Form1 : Form
	{
		// для карты
		public MAP mp = new MAP();



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
			this.Panel_res.Controls.Clear();
			this.mp.main_map = null;
			this.mp.result_map = null;
			this.PICA.Image = new Bitmap(10, 10);
			this.PICA.Size = new Size(0, 0);
		}

		private void Save_Map_ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (this.mp.main_map != null)
			{
				saveFileDialog1.Title = "Сохранить наработки";
				saveFileDialog1.Filter = ABC_lib_01.fileFormat_map;
				if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
					return;
				//MessageBox.Show("11");
				//this.mp.Save_map(saveFileDialog1.FileName);


				string base64String = ABC_lib_01.BitMapToString(this.mp.main_map);

				XElement map = new XElement("Map");
				List<XAttribute> Atriguts = new List<XAttribute>();
				Atriguts.Add(new XAttribute("main_map", base64String));
				XElement dan = new XElement("Danna", ABC_lib_01.MYMetka, Atriguts);
				map.Add(dan);
				Atriguts.Clear();
				foreach (Resource r in this.Panel_res.Controls) {
					Atriguts.Add(new XAttribute("name_resource", r.name_res.Text));
					Atriguts.Add(new XAttribute("w_x", r.numericUpDown1.Value));
					Atriguts.Add(new XAttribute("w_y", r.numericUpDown2.Value));
					Atriguts.Add(new XAttribute("icon", ABC_lib_01.BitMapToString((Bitmap)r.Resource_icon.Image)));

					XElement res = new XElement("Resourse", ABC_lib_01.MYMetka, Atriguts);
					List<XAttribute> xy = new List<XAttribute>();
					foreach (XYcoor c in r.coordinates.Controls) {
						xy.Add(new XAttribute("x", c.Xcoor.Value));
						xy.Add(new XAttribute("y", c.Ycoor.Value));
						XElement XYc = new XElement("XYc", ABC_lib_01.MYMetka, xy);
						xy.Clear();
						res.Add(XYc);
					}
					Atriguts.Clear();
					map.Add(res);
				}
				File.WriteAllText(saveFileDialog1.FileName, map.ToString());
			}
			GC.Collect();
		}

		private void Open_Map_ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			openFileDialog1.Title = "Открыть наработки";
			this.openFileDialog1.Filter = ABC_lib_01.fileFormat_map;
			if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				var fileStream = this.openFileDialog1.OpenFile();
				using (StreamReader reader = new StreamReader(fileStream))
				{
					string b64im = reader.ReadToEnd();
				
					XElement map = XDocument.Parse(b64im).Element("Map");
					this.mp.main_map = ABC_lib_01.StringToMapBit(map.Element("Danna").Attribute("main_map").Value.ToString());
					ABC_lib_01.MaxRandomW = this.mp.main_map.Width;
					ABC_lib_01.MaxRandomH = this.mp.main_map.Height;
					List<XElement> resoursers = map.Elements("Resourse").ToList();

					foreach (XElement xe_res in resoursers) {
						Resource res = new Resource(this);
						res.name_res.Text = xe_res.Attribute("name_resource").Value.ToString();
						res.Dock = DockStyle.Top;
						res.numericUpDown1.Value = int.Parse(xe_res.Attribute("w_x").Value.ToString());
						res.numericUpDown2.Value = int.Parse(xe_res.Attribute("w_y").Value.ToString());
						res.SetIcon(ABC_lib_01.StringToMapBit(xe_res.Attribute("icon").Value.ToString()));
						List<XElement> XY_xe = xe_res.Elements("XYc").ToList();
						res.countRess.Value = XY_xe.Count();

						foreach (XElement xy_c in XY_xe)
						{
							XYcoor xyc = new XYcoor();
							xyc.Xcoor.Value = int.Parse(xy_c.Attribute("x").Value.ToString());
							xyc.Ycoor.Value = int.Parse(xy_c.Attribute("y").Value.ToString());
							xyc.Dock = DockStyle.Top;
							res.coordinates.Controls.Add(xyc);
						}
						//this.resourses.Add(res);
						this.Panel_res.Controls.Add(res);
					}
					setImageMainMap(this.mp.main_map);
					
				}
			}
			GC.Collect();
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

		private void картинкаToolStripMenuItem_Click(object sender, EventArgs e)
		{
			using (OpenFileDialog dlg = new OpenFileDialog())
			{
				dlg.Title = "Импорт картинки";
				dlg.Filter = ABC_lib_01.fileFormat_img;

				if (dlg.ShowDialog() == DialogResult.OK) {
					this.mp.main_map = new Bitmap(dlg.FileName);
					setImageMainMap(this.mp.main_map);
				}
			}
		}

		private void setImageMainMap(Bitmap btm)
		{
			this.PICA.Width = btm.Width;
			this.PICA.Height = btm.Height;
			generateRealRes();
		}

		private void добавитьРесурсToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Resource r = new Resource(this);
			r.Dock = DockStyle.Top;
			//this.resourses.Add(r);
			this.Panel_res.Controls.Add(r);
		}

		public void deleteRes(Resource r) {
			//this.resourses.Remove(r);
			this.Panel_res.Controls.Remove(r);
		}

		private void generateRealRes() {
			this.mp.result_map = new Bitmap(this.mp.main_map.Width, this.mp.main_map.Height);
			for (int h = 0, w = 0; h< this.mp.main_map.Height; h++) {
				for (w = 0; w < this.mp.main_map.Width; w++) {
					this.mp.result_map.SetPixel(w, h, this.mp.main_map.GetPixel(w, h));
					foreach (Resource res in this.Panel_res.Controls) {
						try
						{
							foreach (XYcoor xyc in res.coordinates.Controls)
							{
								if (res.inRes(w, h, xyc))
								{
									this.mp.result_map.SetPixel(w, h, ABC_lib_01.Summ_method_3(this.mp.result_map.GetPixel(w, h), res.getColor(w, h, xyc)));
								}
							}
						}
						catch (NullReferenceException nrf)
						{
							continue;
						}
					}
				}
			}
			this.PICA.Image = this.mp.result_map;
		}

		private void ресурсыToolStripMenuItem_Click(object sender, EventArgs e)
		{
			generateRealRes();
		}

		private void разместитьРесурсыToolStripMenuItem_Click(object sender, EventArgs e)
		{
			foreach (Resource res in this.Panel_res.Controls)
			{
				foreach (XYcoor xyc in res.coordinates.Controls)
				{
					xyc.Xcoor.Value = ABC_lib_01.random.Next((int)xyc.Xcoor.Maximum);
					xyc.Ycoor.Value = ABC_lib_01.random.Next((int)xyc.Ycoor.Maximum);
				}
			}
			generateRealRes();
		}

		private void экспортКартинкиToolStripMenuItem_Click(object sender, EventArgs e)
		{
			saveFileDialog1.Title = "Экспортировать карту";
			saveFileDialog1.Filter = ABC_lib_01.fileFormat_img;
			if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
				return;
			ImageFormat _if;
			switch (saveFileDialog1.FilterIndex) {
				case 1: {
						_if = ImageFormat.Bmp;
						break;
					}
				case 4:
					{
						_if = ImageFormat.Png;
						break;
					}
				default:
					{
						_if = ImageFormat.Jpeg;
						break;
					}
			}
			this.mp.result_map.Save(saveFileDialog1.FileName, _if);
		}
	}
}
