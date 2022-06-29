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
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(800, 24);
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
            this.закрытьПрограммуToolStripMenuItem});
			this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
			this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
			this.файлToolStripMenuItem.Text = "Файл";
			// 
			// новаяКартаToolStripMenuItem
			// 
			this.новаяКартаToolStripMenuItem.Name = "новаяКартаToolStripMenuItem";
			this.новаяКартаToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
			this.новаяКартаToolStripMenuItem.Text = "Новая карта";
			// 
			// открытьКартуToolStripMenuItem
			// 
			this.открытьКартуToolStripMenuItem.Name = "открытьКартуToolStripMenuItem";
			this.открытьКартуToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
			this.открытьКартуToolStripMenuItem.Text = "Открыть карту";
			// 
			// сохранитьКартуToolStripMenuItem
			// 
			this.сохранитьКартуToolStripMenuItem.Name = "сохранитьКартуToolStripMenuItem";
			this.сохранитьКартуToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
			this.сохранитьКартуToolStripMenuItem.Text = "Сохранить карту";
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
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
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
	}
}

