using System.Collections.Generic;

namespace MappingResources
{
	partial class Resource
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
			this.name_res = new System.Windows.Forms.TextBox();
			this.Resource_icon = new System.Windows.Forms.PictureBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.coordinates = new System.Windows.Forms.Panel();
			this.countRess = new System.Windows.Forms.NumericUpDown();
			this.Reset = new System.Windows.Forms.Button();
			this.UpDown = new System.Windows.Forms.Button();
			this.delete_button = new System.Windows.Forms.Button();
			this.ofd = new System.Windows.Forms.OpenFileDialog();
			this._Show = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize)(this.Resource_icon)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.countRess)).BeginInit();
			this.SuspendLayout();
			// 
			// name_res
			// 
			this.name_res.BackColor = System.Drawing.SystemColors.Control;
			this.name_res.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.name_res.Location = new System.Drawing.Point(59, 5);
			this.name_res.Name = "name_res";
			this.name_res.Size = new System.Drawing.Size(188, 13);
			this.name_res.TabIndex = 0;
			this.name_res.Enter += new System.EventHandler(this.inputGotFocus);
			this.name_res.Leave += new System.EventHandler(this.inputLostFocus);
			// 
			// Resource_icon
			// 
			this.Resource_icon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Resource_icon.Location = new System.Drawing.Point(3, 5);
			this.Resource_icon.Name = "Resource_icon";
			this.Resource_icon.Size = new System.Drawing.Size(50, 50);
			this.Resource_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.Resource_icon.TabIndex = 1;
			this.Resource_icon.TabStop = false;
			this.Resource_icon.Click += new System.EventHandler(this.pic_click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.numericUpDown2);
			this.groupBox1.Controls.Add(this.numericUpDown1);
			this.groupBox1.Location = new System.Drawing.Point(55, 25);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(192, 45);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "размер иконки";
			this.groupBox1.Click += new System.EventHandler(this.valueSizeChange);
			// 
			// numericUpDown2
			// 
			this.numericUpDown2.Enabled = false;
			this.numericUpDown2.Location = new System.Drawing.Point(101, 18);
			this.numericUpDown2.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
			this.numericUpDown2.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
			this.numericUpDown2.Name = "numericUpDown2";
			this.numericUpDown2.Size = new System.Drawing.Size(85, 20);
			this.numericUpDown2.TabIndex = 1;
			this.numericUpDown2.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Enabled = false;
			this.numericUpDown1.Location = new System.Drawing.Point(6, 18);
			this.numericUpDown1.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
			this.numericUpDown1.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(85, 20);
			this.numericUpDown1.TabIndex = 0;
			this.numericUpDown1.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
			// 
			// coordinates
			// 
			this.coordinates.AutoScroll = true;
			this.coordinates.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.coordinates.Location = new System.Drawing.Point(3, 102);
			this.coordinates.Name = "coordinates";
			this.coordinates.Size = new System.Drawing.Size(250, 174);
			this.coordinates.TabIndex = 3;
			// 
			// countRess
			// 
			this.countRess.Location = new System.Drawing.Point(3, 76);
			this.countRess.Name = "countRess";
			this.countRess.Size = new System.Drawing.Size(120, 20);
			this.countRess.TabIndex = 4;
			// 
			// Reset
			// 
			this.Reset.Location = new System.Drawing.Point(126, 76);
			this.Reset.Name = "Reset";
			this.Reset.Size = new System.Drawing.Size(40, 23);
			this.Reset.TabIndex = 5;
			this.Reset.Text = "↻";
			this.Reset.UseVisualStyleBackColor = true;
			this.Reset.Click += new System.EventHandler(this.Reset_Click);
			// 
			// UpDown
			// 
			this.UpDown.Location = new System.Drawing.Point(167, 76);
			this.UpDown.Name = "UpDown";
			this.UpDown.Size = new System.Drawing.Size(40, 23);
			this.UpDown.TabIndex = 6;
			this.UpDown.Text = "▼";
			this.UpDown.UseVisualStyleBackColor = true;
			this.UpDown.Click += new System.EventHandler(this.UpDown_Click);
			// 
			// delete_button
			// 
			this.delete_button.Location = new System.Drawing.Point(208, 76);
			this.delete_button.Name = "delete_button";
			this.delete_button.Size = new System.Drawing.Size(40, 23);
			this.delete_button.TabIndex = 7;
			this.delete_button.Text = "X";
			this.delete_button.UseVisualStyleBackColor = true;
			this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
			// 
			// Show
			// 
			this._Show.AutoSize = true;
			this._Show.Checked = true;
			this._Show.CheckState = System.Windows.Forms.CheckState.Checked;
			this._Show.Location = new System.Drawing.Point(3, 57);
			this._Show.Name = "Show";
			this._Show.Size = new System.Drawing.Size(53, 17);
			this._Show.TabIndex = 8;
			this._Show.Text = "Show";
			this._Show.UseVisualStyleBackColor = true;
			// 
			// Resource
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Controls.Add(this._Show);
			this.Controls.Add(this.delete_button);
			this.Controls.Add(this.UpDown);
			this.Controls.Add(this.Reset);
			this.Controls.Add(this.countRess);
			this.Controls.Add(this.coordinates);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.Resource_icon);
			this.Controls.Add(this.name_res);
			this.Name = "Resource";
			this.Size = new System.Drawing.Size(250, 279);
			((System.ComponentModel.ISupportInitialize)(this.Resource_icon)).EndInit();
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.countRess)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		private void Name_res_CursorChanged(object sender, System.EventArgs e)
		{
			throw new System.NotImplementedException();
		}

		#endregion

		public System.Windows.Forms.TextBox name_res;
		public System.Windows.Forms.PictureBox Resource_icon;
		private System.Windows.Forms.GroupBox groupBox1;
		public System.Windows.Forms.NumericUpDown numericUpDown2;
		public System.Windows.Forms.NumericUpDown numericUpDown1;
		public System.Windows.Forms.Panel coordinates;
		public System.Windows.Forms.NumericUpDown countRess;
		private System.Windows.Forms.Button Reset;
		private System.Windows.Forms.Button UpDown;
		private System.Windows.Forms.Button delete_button;
		private System.Windows.Forms.OpenFileDialog ofd;
		public System.Windows.Forms.CheckBox _Show;
	}
}
