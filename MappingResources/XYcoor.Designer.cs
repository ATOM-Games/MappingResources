namespace MappingResources
{
	partial class XYcoor
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

		#region Код, автоматически созданный конструктором компонентов

		private void InitializeComponent()
		{
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.Xcoor = new System.Windows.Forms.NumericUpDown();
			this.Ycoor = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Xcoor)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ycoor)).BeginInit();
			this.SuspendLayout();
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.Xcoor);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.Ycoor);
			this.splitContainer1.Size = new System.Drawing.Size(455, 22);
			this.splitContainer1.SplitterDistance = 151;
			this.splitContainer1.TabIndex = 0;
			// 
			// Xcoor
			// 
			this.Xcoor.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Xcoor.Location = new System.Drawing.Point(0, 0);
			this.Xcoor.Name = "Xcoor";
			this.Xcoor.Size = new System.Drawing.Size(151, 20);
			this.Xcoor.TabIndex = 0;
			this.Xcoor.Maximum = int.MaxValue;
			// 
			// Ycoor
			// 
			this.Ycoor.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Ycoor.Location = new System.Drawing.Point(0, 0);
			this.Ycoor.Name = "Ycoor";
			this.Ycoor.Size = new System.Drawing.Size(300, 20);
			this.Ycoor.TabIndex = 0;
			this.Ycoor.Maximum = int.MaxValue;
			// 
			// XYcoor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.splitContainer1);
			this.Name = "XYcoor";
			this.Size = new System.Drawing.Size(455, 22);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.Xcoor)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ycoor)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		public System.Windows.Forms.NumericUpDown Xcoor;
		public System.Windows.Forms.NumericUpDown Ycoor;
	}
}
