namespace MappingResources
{
	partial class SetSeed
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

		#region Windows Form Designer generated code

		private void InitializeComponent()
		{
			this.SEDD = new System.Windows.Forms.NumericUpDown();
			this.SetSdreal_seed = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.SEDD)).BeginInit();
			this.SuspendLayout();
			// 
			// SEDD
			// 
			this.SEDD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.SEDD.Location = new System.Drawing.Point(12, 12);
			this.SEDD.Name = "SEDD";
			this.SEDD.Size = new System.Drawing.Size(390, 29);
			this.SEDD.TabIndex = 0;
			this.SEDD.Minimum = int.MinValue;
			this.SEDD.Maximum = int.MaxValue;
			// 
			// SetSdreal_seed
			// 
			this.SetSdreal_seed.Location = new System.Drawing.Point(12, 47);
			this.SetSdreal_seed.Name = "SetSdreal_seed";
			this.SetSdreal_seed.Size = new System.Drawing.Size(166, 23);
			this.SetSdreal_seed.TabIndex = 1;
			this.SetSdreal_seed.Text = "Установить сид";
			this.SetSdreal_seed.UseVisualStyleBackColor = true;
			this.SetSdreal_seed.Click += new System.EventHandler(this.SetSdreal_seed_Click);
			// 
			// SetSeed
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(414, 91);
			this.Controls.Add(this.SetSdreal_seed);
			this.Controls.Add(this.SEDD);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "SetSeed";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Установить сид";
			((System.ComponentModel.ISupportInitialize)(this.SEDD)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.NumericUpDown SEDD;
		private System.Windows.Forms.Button SetSdreal_seed;
	}
}