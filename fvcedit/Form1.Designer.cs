namespace fvcedit
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.bBar = new System.Windows.Forms.TrackBar();
			this.gBar = new System.Windows.Forms.TrackBar();
			this.rBar = new System.Windows.Forms.TrackBar();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.trackBar6 = new System.Windows.Forms.TrackBar();
			this.trackBar4 = new System.Windows.Forms.TrackBar();
			this.trackBar5 = new System.Windows.Forms.TrackBar();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.bBar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gBar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.rBar)).BeginInit();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBar6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBar4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBar5)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox1.Location = new System.Drawing.Point(12, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(776, 350);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// tabControl1
			// 
			this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Location = new System.Drawing.Point(12, 368);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(564, 117);
			this.tabControl1.TabIndex = 1;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.label4);
			this.tabPage1.Controls.Add(this.label3);
			this.tabPage1.Controls.Add(this.label2);
			this.tabPage1.Controls.Add(this.bBar);
			this.tabPage1.Controls.Add(this.gBar);
			this.tabPage1.Controls.Add(this.rBar);
			this.tabPage1.Location = new System.Drawing.Point(4, 24);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(556, 89);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "RGBmanager";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(226, 54);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(13, 15);
			this.label4.TabIndex = 5;
			this.label4.Text = "0";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(116, 54);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(13, 15);
			this.label3.TabIndex = 4;
			this.label3.Text = "0";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 54);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(13, 15);
			this.label2.TabIndex = 3;
			this.label2.Text = "0";
			// 
			// bBar
			// 
			this.bBar.BackColor = System.Drawing.Color.SteelBlue;
			this.bBar.Location = new System.Drawing.Point(226, 6);
			this.bBar.Maximum = 255;
			this.bBar.Minimum = -255;
			this.bBar.Name = "bBar";
			this.bBar.Size = new System.Drawing.Size(104, 45);
			this.bBar.TabIndex = 2;
			this.bBar.Scroll += new System.EventHandler(this.trackBar3_Scroll);
			// 
			// gBar
			// 
			this.gBar.BackColor = System.Drawing.Color.ForestGreen;
			this.gBar.Location = new System.Drawing.Point(116, 6);
			this.gBar.Maximum = 255;
			this.gBar.Minimum = -255;
			this.gBar.Name = "gBar";
			this.gBar.Size = new System.Drawing.Size(104, 45);
			this.gBar.TabIndex = 1;
			this.gBar.Scroll += new System.EventHandler(this.trackBar2_Scroll);
			// 
			// rBar
			// 
			this.rBar.BackColor = System.Drawing.Color.Maroon;
			this.rBar.Location = new System.Drawing.Point(6, 6);
			this.rBar.Maximum = 255;
			this.rBar.Minimum = -255;
			this.rBar.Name = "rBar";
			this.rBar.Size = new System.Drawing.Size(104, 45);
			this.rBar.TabIndex = 0;
			this.rBar.Scroll += new System.EventHandler(this.trackBar1_Scroll);
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.trackBar6);
			this.tabPage2.Controls.Add(this.trackBar4);
			this.tabPage2.Controls.Add(this.trackBar5);
			this.tabPage2.Location = new System.Drawing.Point(4, 24);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(556, 89);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "HSBmanager";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// trackBar6
			// 
			this.trackBar6.BackColor = System.Drawing.Color.OldLace;
			this.trackBar6.Location = new System.Drawing.Point(226, 6);
			this.trackBar6.Maximum = 100;
			this.trackBar6.Name = "trackBar6";
			this.trackBar6.Size = new System.Drawing.Size(104, 45);
			this.trackBar6.TabIndex = 5;
			// 
			// trackBar4
			// 
			this.trackBar4.BackColor = System.Drawing.Color.Goldenrod;
			this.trackBar4.Location = new System.Drawing.Point(116, 6);
			this.trackBar4.Maximum = 100;
			this.trackBar4.Name = "trackBar4";
			this.trackBar4.Size = new System.Drawing.Size(104, 45);
			this.trackBar4.TabIndex = 4;
			// 
			// trackBar5
			// 
			this.trackBar5.BackColor = System.Drawing.Color.Maroon;
			this.trackBar5.Location = new System.Drawing.Point(6, 6);
			this.trackBar5.Maximum = 360;
			this.trackBar5.Name = "trackBar5";
			this.trackBar5.Size = new System.Drawing.Size(104, 45);
			this.trackBar5.TabIndex = 3;
			// 
			// tabPage3
			// 
			this.tabPage3.Location = new System.Drawing.Point(4, 24);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Size = new System.Drawing.Size(556, 89);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Effectmanager";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(683, 433);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(105, 23);
			this.button1.TabIndex = 2;
			this.button1.Text = "Load frame";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(578, 433);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(99, 23);
			this.button2.TabIndex = 3;
			this.button2.Text = "Save frame";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(578, 404);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(210, 23);
			this.textBox1.TabIndex = 4;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(578, 386);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(92, 15);
			this.label1.TabIndex = 5;
			this.label1.Text = "Frame filename:";
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(683, 462);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(105, 23);
			this.button3.TabIndex = 6;
			this.button3.Text = "Apply changes";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(578, 462);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(99, 23);
			this.button4.TabIndex = 7;
			this.button4.Text = "Reset changes";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.ClientSize = new System.Drawing.Size(800, 497);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.pictureBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.Text = "FormVideoColoredit";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.bBar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gBar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.rBar)).EndInit();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBar6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBar4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBar5)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private PictureBox pictureBox1;
		private TabControl tabControl1;
		private TabPage tabPage1;
		private TabPage tabPage2;
		private Button button1;
		private Button button2;
		private TextBox textBox1;
		private TabPage tabPage3;
		private Label label1;
		private TrackBar bBar;
		private TrackBar gBar;
		private TrackBar rBar;
		private TrackBar trackBar5;
		private Button button3;
		private TrackBar trackBar6;
		private TrackBar trackBar4;
		private Label label4;
		private Label label3;
		private Label label2;
		private Button button4;
	}
}