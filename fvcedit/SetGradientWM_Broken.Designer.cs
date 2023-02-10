namespace fvcedit
{
	partial class SetGradientWM_Broken
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetGradientWM_Broken));
			this.tilefxy = new System.Windows.Forms.RadioButton();
			this.tilefy = new System.Windows.Forms.RadioButton();
			this.label5 = new System.Windows.Forms.Label();
			this.tilefx = new System.Windows.Forms.RadioButton();
			this.tile = new System.Windows.Forms.RadioButton();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// tilefxy
			// 
			this.tilefxy.AutoSize = true;
			this.tilefxy.Location = new System.Drawing.Point(0, 0);
			this.tilefxy.Margin = new System.Windows.Forms.Padding(45, 18, 45, 18);
			this.tilefxy.Name = "tilefxy";
			this.tilefxy.Size = new System.Drawing.Size(95, 24);
			this.tilefxy.TabIndex = 21;
			this.tilefxy.Text = "TileFlipXY";
			this.tilefxy.UseVisualStyleBackColor = true;
			// 
			// tilefy
			// 
			this.tilefy.AutoSize = true;
			this.tilefy.Location = new System.Drawing.Point(0, 0);
			this.tilefy.Margin = new System.Windows.Forms.Padding(45, 18, 45, 18);
			this.tilefy.Name = "tilefy";
			this.tilefy.Size = new System.Drawing.Size(86, 24);
			this.tilefy.TabIndex = 20;
			this.tilefy.Text = "TileFlipY";
			this.tilefy.UseVisualStyleBackColor = true;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(0, 0);
			this.label5.Margin = new System.Windows.Forms.Padding(45, 0, 45, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(91, 20);
			this.label5.TabIndex = 19;
			this.label5.Text = "Wrap mode:";
			// 
			// tilefx
			// 
			this.tilefx.AutoSize = true;
			this.tilefx.Location = new System.Drawing.Point(0, 0);
			this.tilefx.Margin = new System.Windows.Forms.Padding(45, 18, 45, 18);
			this.tilefx.Name = "tilefx";
			this.tilefx.Size = new System.Drawing.Size(87, 24);
			this.tilefx.TabIndex = 18;
			this.tilefx.Text = "TileFlipX";
			this.tilefx.UseVisualStyleBackColor = true;
			// 
			// tile
			// 
			this.tile.AutoSize = true;
			this.tile.Location = new System.Drawing.Point(0, 0);
			this.tile.Margin = new System.Windows.Forms.Padding(45, 18, 45, 18);
			this.tile.Name = "tile";
			this.tile.Size = new System.Drawing.Size(54, 24);
			this.tile.TabIndex = 17;
			this.tile.Text = "Tile";
			this.tile.UseVisualStyleBackColor = true;
			this.tile.CheckedChanged += new System.EventHandler(this.wrapChange);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(571, 194);
			this.button1.Margin = new System.Windows.Forms.Padding(45, 18, 45, 18);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(47, 29);
			this.button1.TabIndex = 23;
			this.button1.Text = "OK";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// SetGradientWM
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.ClientSize = new System.Drawing.Size(672, 250);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.tilefxy);
			this.Controls.Add(this.tilefy);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.tilefx);
			this.Controls.Add(this.tile);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(45, 18, 45, 18);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "SetGradientWM";
			this.Text = "Set gradient wrap mode";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private RadioButton tilefxy;
		private RadioButton tilefy;
		private Label label5;
		private RadioButton tilefx;
		private RadioButton tile;
		private Button button1;
	}
}