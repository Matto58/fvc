namespace fvcedit
{
	partial class SetGradientWM
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetGradientWM));
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.tile = new System.Windows.Forms.RadioButton();
			this.tilefx = new System.Windows.Forms.RadioButton();
			this.tilefy = new System.Windows.Forms.RadioButton();
			this.tilefxy = new System.Windows.Forms.RadioButton();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(181, 92);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(94, 29);
			this.button1.TabIndex = 0;
			this.button1.Text = "OK";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(91, 20);
			this.label1.TabIndex = 1;
			this.label1.Text = "Wrap mode:";
			// 
			// tile
			// 
			this.tile.AutoSize = true;
			this.tile.Location = new System.Drawing.Point(12, 32);
			this.tile.Name = "tile";
			this.tile.Size = new System.Drawing.Size(54, 24);
			this.tile.TabIndex = 2;
			this.tile.TabStop = true;
			this.tile.Text = "Tile";
			this.tile.UseVisualStyleBackColor = true;
			// 
			// tilefx
			// 
			this.tilefx.AutoSize = true;
			this.tilefx.Location = new System.Drawing.Point(72, 32);
			this.tilefx.Name = "tilefx";
			this.tilefx.Size = new System.Drawing.Size(87, 24);
			this.tilefx.TabIndex = 3;
			this.tilefx.TabStop = true;
			this.tilefx.Text = "TileFlipX";
			this.tilefx.UseVisualStyleBackColor = true;
			// 
			// tilefy
			// 
			this.tilefy.AutoSize = true;
			this.tilefy.Location = new System.Drawing.Point(12, 62);
			this.tilefy.Name = "tilefy";
			this.tilefy.Size = new System.Drawing.Size(86, 24);
			this.tilefy.TabIndex = 4;
			this.tilefy.TabStop = true;
			this.tilefy.Text = "TileFlipY";
			this.tilefy.UseVisualStyleBackColor = true;
			// 
			// tilefxy
			// 
			this.tilefxy.AutoSize = true;
			this.tilefxy.Location = new System.Drawing.Point(104, 62);
			this.tilefxy.Name = "tilefxy";
			this.tilefxy.Size = new System.Drawing.Size(95, 24);
			this.tilefxy.TabIndex = 5;
			this.tilefxy.TabStop = true;
			this.tilefxy.Text = "TileFlipXY";
			this.tilefxy.UseVisualStyleBackColor = true;
			// 
			// SetGradientWM
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(287, 133);
			this.Controls.Add(this.tilefxy);
			this.Controls.Add(this.tilefy);
			this.Controls.Add(this.tilefx);
			this.Controls.Add(this.tile);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "SetGradientWM";
			this.Text = "Set gradient wrap mode";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Button button1;
		private Label label1;
		private RadioButton tile;
		private RadioButton tilefx;
		private RadioButton tilefy;
		private RadioButton tilefxy;
	}
}