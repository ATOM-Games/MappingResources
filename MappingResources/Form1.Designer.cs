using System.Collections.Generic;

namespace MappingResources
{
	partial class Form1
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

		#region Код, автоматически созданный конструктором форм Windows

		private void InitializeComponent()
		{
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.новаяКартаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.открытьКартуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.сохранитьКартуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.закрытьПрограммуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.картинкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
			this.сгенеритьСидToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ресурсыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.добавитьРесурсToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.PICA = new System.Windows.Forms.PictureBox();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.panel_PIC = new System.Windows.Forms.Panel();
			this.Panel_res = new System.Windows.Forms.Panel();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.разместитьРесурсыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.экспортКартинкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.PICA)).BeginInit();
			this.panel_PIC.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.toolStripTextBox1,
            this.сгенеритьСидToolStripMenuItem,
            this.разместитьРесурсыToolStripMenuItem,
            this.ресурсыToolStripMenuItem,
            this.добавитьРесурсToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(800, 27);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// файлToolStripMenuItem
			// 
			this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новаяКартаToolStripMenuItem,
            this.открытьКартуToolStripMenuItem,
            this.сохранитьКартуToolStripMenuItem,
            this.toolStripSeparator1,
            this.закрытьПрограммуToolStripMenuItem,
            this.картинкаToolStripMenuItem,
            this.экспортКартинкиToolStripMenuItem});
			this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
			this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 23);
			this.файлToolStripMenuItem.Text = "Файл";
			// 
			// новаяКартаToolStripMenuItem
			// 
			this.новаяКартаToolStripMenuItem.Name = "новаяКартаToolStripMenuItem";
			this.новаяКартаToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
			this.новаяКартаToolStripMenuItem.Text = "Новая карта";
			this.новаяКартаToolStripMenuItem.Click += new System.EventHandler(this.New_Map_ToolStripMenuItem_Click);
			// 
			// открытьКартуToolStripMenuItem
			// 
			this.открытьКартуToolStripMenuItem.Name = "открытьКартуToolStripMenuItem";
			this.открытьКартуToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
			this.открытьКартуToolStripMenuItem.Text = "Открыть карту";
			this.открытьКартуToolStripMenuItem.Click += new System.EventHandler(this.Open_Map_ToolStripMenuItem_Click);
			// 
			// сохранитьКартуToolStripMenuItem
			// 
			this.сохранитьКартуToolStripMenuItem.Name = "сохранитьКартуToolStripMenuItem";
			this.сохранитьКартуToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
			this.сохранитьКартуToolStripMenuItem.Text = "Сохранить карту";
			this.сохранитьКартуToolStripMenuItem.Click += new System.EventHandler(this.Save_Map_ToolStripMenuItem_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(183, 6);
			// 
			// закрытьПрограммуToolStripMenuItem
			// 
			this.закрытьПрограммуToolStripMenuItem.Name = "закрытьПрограммуToolStripMenuItem";
			this.закрытьПрограммуToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
			this.закрытьПрограммуToolStripMenuItem.Text = "Закрыть программу";
			this.закрытьПрограммуToolStripMenuItem.Click += new System.EventHandler(this.Close_programm_ToolStripMenuItem_Click);
			// 
			// картинкаToolStripMenuItem
			// 
			this.картинкаToolStripMenuItem.Name = "картинкаToolStripMenuItem";
			this.картинкаToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
			this.картинкаToolStripMenuItem.Text = "Импорт картинки (карта)";
			this.картинкаToolStripMenuItem.Click += new System.EventHandler(this.картинкаToolStripMenuItem_Click);
			// 
			// toolStripTextBox1
			// 
			this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.toolStripTextBox1.Name = "toolStripTextBox1";
			this.toolStripTextBox1.ReadOnly = true;
			this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
			this.toolStripTextBox1.Click += new System.EventHandler(this.toolStripTextBox1_Click);
			// 
			// сгенеритьСидToolStripMenuItem
			// 
			this.сгенеритьСидToolStripMenuItem.Name = "сгенеритьСидToolStripMenuItem";
			this.сгенеритьСидToolStripMenuItem.Size = new System.Drawing.Size(98, 23);
			this.сгенеритьСидToolStripMenuItem.Text = "Сгенерить сид";
			this.сгенеритьСидToolStripMenuItem.Click += new System.EventHandler(this.SeedToolStripMenuItem_Click);
			// 
			// ресурсыToolStripMenuItem
			// 
			this.ресурсыToolStripMenuItem.Name = "ресурсыToolStripMenuItem";
			this.ресурсыToolStripMenuItem.Size = new System.Drawing.Size(119, 23);
			this.ресурсыToolStripMenuItem.Text = "Показать ресурсы";
			this.ресурсыToolStripMenuItem.Click += new System.EventHandler(this.ресурсыToolStripMenuItem_Click);
			// 
			// добавитьРесурсToolStripMenuItem
			// 
			this.добавитьРесурсToolStripMenuItem.Name = "добавитьРесурсToolStripMenuItem";
			this.добавитьРесурсToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.добавитьРесурсToolStripMenuItem.Size = new System.Drawing.Size(112, 23);
			this.добавитьРесурсToolStripMenuItem.Text = "Добавить ресурс";
			this.добавитьРесурсToolStripMenuItem.Click += new System.EventHandler(this.добавитьРесурсToolStripMenuItem_Click);
			// 
			// PICA
			// 
			this.PICA.Location = new System.Drawing.Point(10, 10);
			this.PICA.Margin = new System.Windows.Forms.Padding(10);
			this.PICA.Name = "PICA";
			this.PICA.Size = new System.Drawing.Size(208, 195);
			this.PICA.TabIndex = 1;
			this.PICA.TabStop = false;
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// panel_PIC
			// 
			this.panel_PIC.AutoScroll = true;
			this.panel_PIC.AutoScrollMargin = new System.Drawing.Size(10, 10);
			this.panel_PIC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel_PIC.Controls.Add(this.PICA);
			this.panel_PIC.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel_PIC.Location = new System.Drawing.Point(0, 27);
			this.panel_PIC.Name = "panel_PIC";
			this.panel_PIC.Padding = new System.Windows.Forms.Padding(10);
			this.panel_PIC.Size = new System.Drawing.Size(500, 423);
			this.panel_PIC.TabIndex = 2;
			// 
			// Panel_res
			// 
			this.Panel_res.AutoScroll = true;
			this.Panel_res.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Panel_res.Dock = System.Windows.Forms.DockStyle.Right;
			this.Panel_res.Location = new System.Drawing.Point(500, 27);
			this.Panel_res.Name = "Panel_res";
			this.Panel_res.Size = new System.Drawing.Size(300, 423);
			this.Panel_res.TabIndex = 3;
			// 
			// разместитьРесурсыToolStripMenuItem
			// 
			this.разместитьРесурсыToolStripMenuItem.Name = "разместитьРесурсыToolStripMenuItem";
			this.разместитьРесурсыToolStripMenuItem.Size = new System.Drawing.Size(131, 23);
			this.разместитьРесурсыToolStripMenuItem.Text = "Разместить ресурсы";
			this.разместитьРесурсыToolStripMenuItem.Click += new System.EventHandler(this.разместитьРесурсыToolStripMenuItem_Click);
			// 
			// экспортКартинкиToolStripMenuItem
			// 
			this.экспортКартинкиToolStripMenuItem.Name = "экспортКартинкиToolStripMenuItem";
			this.экспортКартинкиToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
			this.экспортКартинкиToolStripMenuItem.Text = "Экспорт картинки";
			this.экспортКартинкиToolStripMenuItem.Click += new System.EventHandler(this.экспортКартинкиToolStripMenuItem_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.panel_PIC);
			this.Controls.Add(this.Panel_res);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.PICA)).EndInit();
			this.panel_PIC.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem новаяКартаToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem открытьКартуToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem сохранитьКартуToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem закрытьПрограммуToolStripMenuItem;
		public System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
		private System.Windows.Forms.ToolStripMenuItem сгенеритьСидToolStripMenuItem;
		private System.Windows.Forms.PictureBox PICA;
		private System.Windows.Forms.ToolStripMenuItem картинкаToolStripMenuItem;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Panel panel_PIC;
		private System.Windows.Forms.Panel Panel_res;
		private System.Windows.Forms.ToolStripMenuItem ресурсыToolStripMenuItem;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		//private List<Resource> resourses;
		private System.Windows.Forms.ToolStripMenuItem добавитьРесурсToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem разместитьРесурсыToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem экспортКартинкиToolStripMenuItem;
	}
}

