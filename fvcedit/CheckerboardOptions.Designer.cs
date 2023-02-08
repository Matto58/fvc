namespace fvcedit
{
	partial class CheckerboardOptions
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckerboardOptions));
			this.cbColorDark = new System.Windows.Forms.ColorDialog();
			this.cbColorBright = new System.Windows.Forms.ColorDialog();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.label1 = new System.Windows.Forms.Label();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.button3 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// cbColorDark
			// 
			this.cbColorDark.AnyColor = true;
			// 
			// cbColorBright
			// 
			this.cbColorBright.Color = System.Drawing.Color.White;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(12, 67);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(163, 29);
			this.button1.TabIndex = 0;
			this.button1.Text = "Select dark color";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(12, 32);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(163, 29);
			this.button2.TabIndex = 1;
			this.button2.Text = "Select bright color";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox1.Location = new System.Drawing.Point(181, 67);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(29, 29);
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox2.Location = new System.Drawing.Point(181, 32);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(29, 29);
			this.pictureBox2.TabIndex = 3;
			this.pictureBox2.TabStop = false;
			// 
			// radioButton1
			// 
			this.radioButton1.AutoSize = true;
			this.radioButton1.Checked = true;
			this.radioButton1.Location = new System.Drawing.Point(12, 122);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(207, 24);
			this.radioButton1.TabIndex = 4;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "Dark, bright, dark, bright, ...";
			this.radioButton1.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 99);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(71, 20);
			this.label1.TabIndex = 5;
			this.label1.Text = "Ordering:";
			// 
			// radioButton2
			// 
			this.radioButton2.AutoSize = true;
			this.radioButton2.Location = new System.Drawing.Point(12, 152);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(205, 24);
			this.radioButton2.TabIndex = 6;
			this.radioButton2.Text = "Bright, dark, bright, dark, ...";
			this.radioButton2.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(201, 252);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(94, 29);
			this.button3.TabIndex = 7;
			this.button3.Text = "OK";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(54, 20);
			this.label2.TabIndex = 8;
			this.label2.Text = "Colors:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 179);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(87, 20);
			this.label3.TabIndex = 9;
			this.label3.Text = "Square size:";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(18, 202);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(48, 27);
			this.textBox1.TabIndex = 10;
			this.textBox1.Text = "80";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(103, 202);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(48, 27);
			this.textBox2.TabIndex = 11;
			this.textBox2.Text = "80";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(72, 205);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(25, 20);
			this.label4.TabIndex = 12;
			this.label4.Text = "by";
			// 
			// CheckerboardOptions
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.ClientSize = new System.Drawing.Size(307, 293);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.radioButton2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.radioButton1);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "CheckerboardOptions";
			this.Text = "Checkerboard options";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		public ColorDialog cbColorDark;
		public ColorDialog cbColorBright;
		public Button button1;
		public Button button2;
		public PictureBox pictureBox1;
		public PictureBox pictureBox2;
		public RadioButton radioButton1;
		public Label label1;
		public RadioButton radioButton2;
		public Button button3;
		public Label label2;
		public Label label3;
		public TextBox textBox1;
		public TextBox textBox2;
		public Label label4;
	}
}