using System.Diagnostics;
using static System.Math;

namespace fvcedit
{
	public partial class Form1 : Form
	{
		Bitmap workingImage = new(1, 1);
		Bitmap finalImage = new(1, 1);

		static Color incrementRgb(Color i, int r, int g, int b)
		{
			return Color.FromArgb(
				Min(Max(i.R + r, 0), 255),
				Min(Max(i.G + g, 0), 255),
				Min(Max(i.B + b, 0), 255)
			);
		}

		public Form1()
		{
			InitializeComponent();
		}

		private void button2_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			workingImage = (Bitmap)Image.FromFile(textBox1.Text);
			finalImage = (Bitmap)workingImage.Clone();
			pictureBox1.BackgroundImage = (Bitmap)finalImage.Clone();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			finalImage = (Bitmap)workingImage.Clone();

			for (int y = 0; y < finalImage.Height; y++)
			{
				for (int x = 0; x < finalImage.Width; x++)
				{
					finalImage.SetPixel(
						x, y,
						incrementRgb(
							finalImage.GetPixel(x, y),
							rBar.Value, gBar.Value, bBar.Value
						)
					);
				}
			}

			Debug.WriteLine("processing done");

			pictureBox1.BackgroundImage = (Bitmap)finalImage.Clone();

			Debug.WriteLine("displaying done");
		}

		private void trackBar1_Scroll(object sender, EventArgs e)
		{
			label2.Text = rBar.Value.ToString();
		}

		private void trackBar2_Scroll(object sender, EventArgs e)
		{
			label3.Text = gBar.Value.ToString();
		}

		private void trackBar3_Scroll(object sender, EventArgs e)
		{
			label4.Text = bBar.Value.ToString();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			finalImage = (Bitmap)workingImage.Clone();
			pictureBox1.BackgroundImage = (Bitmap)workingImage.Clone();

			rBar.Value = 0; trackBar1_Scroll(sender, e);
			gBar.Value = 0; trackBar2_Scroll(sender, e);
			bBar.Value = 0; trackBar3_Scroll(sender, e);
		}
	}
}