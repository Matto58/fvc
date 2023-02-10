namespace fvcedit
{
	partial class TextOverlayOptions
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		public System.ComponentModel.IContainer components = null;

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
		public void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextOverlayOptions));
			this.label14 = new System.Windows.Forms.Label();
			this.textBox7 = new System.Windows.Forms.TextBox();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.checkBox3 = new System.Windows.Forms.CheckBox();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.label12 = new System.Windows.Forms.Label();
			this.checkBox4 = new System.Windows.Forms.CheckBox();
			this.overlayTextColor = new System.Windows.Forms.ColorDialog();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(13, 45);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(34, 20);
			this.label14.TabIndex = 25;
			this.label14.Text = "Pos:";
			// 
			// textBox7
			// 
			this.textBox7.Location = new System.Drawing.Point(115, 42);
			this.textBox7.Name = "textBox7";
			this.textBox7.Size = new System.Drawing.Size(56, 27);
			this.textBox7.TabIndex = 24;
			this.textBox7.Text = "0";
			// 
			// textBox6
			// 
			this.textBox6.Location = new System.Drawing.Point(53, 42);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(56, 27);
			this.textBox6.TabIndex = 23;
			this.textBox6.Text = "0";
			// 
			// checkBox3
			// 
			this.checkBox3.AutoSize = true;
			this.checkBox3.Location = new System.Drawing.Point(12, 12);
			this.checkBox3.Name = "checkBox3";
			this.checkBox3.Size = new System.Drawing.Size(62, 24);
			this.checkBox3.TabIndex = 22;
			this.checkBox3.Text = "Bold";
			this.checkBox3.UseVisualStyleBackColor = true;
			// 
			// checkBox2
			// 
			this.checkBox2.AutoSize = true;
			this.checkBox2.Location = new System.Drawing.Point(80, 12);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(63, 24);
			this.checkBox2.TabIndex = 21;
			this.checkBox2.Text = "Italic";
			this.checkBox2.UseVisualStyleBackColor = true;
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Location = new System.Drawing.Point(149, 12);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(104, 24);
			this.checkBox1.TabIndex = 20;
			this.checkBox1.Text = "Underlined";
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackColor = System.Drawing.Color.Black;
			this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox2.Location = new System.Drawing.Point(53, 75);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(28, 28);
			this.pictureBox2.TabIndex = 19;
			this.pictureBox2.TabStop = false;
			this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(13, 79);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(29, 20);
			this.label12.TabIndex = 18;
			this.label12.Text = "FG:";
			// 
			// checkBox4
			// 
			this.checkBox4.AutoSize = true;
			this.checkBox4.Location = new System.Drawing.Point(259, 12);
			this.checkBox4.Name = "checkBox4";
			this.checkBox4.Size = new System.Drawing.Size(105, 24);
			this.checkBox4.TabIndex = 26;
			this.checkBox4.Text = "Striked-out";
			this.checkBox4.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(271, 73);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(94, 29);
			this.button1.TabIndex = 27;
			this.button1.Text = "OK";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// TextOverlayOptions
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(377, 114);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.checkBox4);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.textBox7);
			this.Controls.Add(this.textBox6);
			this.Controls.Add(this.checkBox3);
			this.Controls.Add(this.checkBox2);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.label12);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "TextOverlayOptions";
			this.Text = "Overlay options";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		public Label label14;
		public TextBox textBox7;
		public TextBox textBox6;
		public CheckBox checkBox3;
		public CheckBox checkBox2;
		public CheckBox checkBox1;
		public PictureBox pictureBox2;
		public Label label12;
		public CheckBox checkBox4;
		public ColorDialog overlayTextColor;
		private Button button1;
	}
}