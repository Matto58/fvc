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


		// https://stackoverflow.com/a/3837824
		public static Color FromAhsb(int alpha, float hue, float saturation, float brightness)
		{

			if (0 > alpha || 255 < alpha)
			{
				throw new ArgumentOutOfRangeException("alpha", alpha,
				  "Value must be within a range of 0 - 255.");
			}
			if (0f > hue || 360f < hue)
			{
				throw new ArgumentOutOfRangeException("hue", hue,
				  "Value must be within a range of 0 - 360.");
			}
			if (0f > saturation || 1f < saturation)
			{
				throw new ArgumentOutOfRangeException("saturation", saturation,
				  "Value must be within a range of 0 - 1.");
			}
			if (0f > brightness || 1f < brightness)
			{
				throw new ArgumentOutOfRangeException("brightness", brightness,
				  "Value must be within a range of 0 - 1.");
			}

			if (0 == saturation)
			{
				return Color.FromArgb(alpha, Convert.ToInt32(brightness * 255),
				  Convert.ToInt32(brightness * 255), Convert.ToInt32(brightness * 255));
			}

			float fMax, fMid, fMin;
			int iSextant, iMax, iMid, iMin;

			if (0.5 < brightness)
			{
				fMax = brightness - (brightness * saturation) + saturation;
				fMin = brightness + (brightness * saturation) - saturation;
			}
			else
			{
				fMax = brightness + (brightness * saturation);
				fMin = brightness - (brightness * saturation);
			}

			iSextant = (int)Floor(hue / 60f);
			if (300f <= hue)
			{
				hue -= 360f;
			}
			hue /= 60f;
			hue -= 2f * (float)Floor(((iSextant + 1f) % 6f) / 2f);
			if (0 == iSextant % 2)
			{
				fMid = hue * (fMax - fMin) + fMin;
			}
			else
			{
				fMid = fMin - hue * (fMax - fMin);
			}

			iMax = Convert.ToInt32(fMax * 255);
			iMid = Convert.ToInt32(fMid * 255);
			iMin = Convert.ToInt32(fMin * 255);

			switch (iSextant)
			{
				case 1:
					return Color.FromArgb(alpha, iMid, iMax, iMin);
				case 2:
					return Color.FromArgb(alpha, iMin, iMax, iMid);
				case 3:
					return Color.FromArgb(alpha, iMin, iMid, iMax);
				case 4:
					return Color.FromArgb(alpha, iMid, iMin, iMax);
				case 5:
					return Color.FromArgb(alpha, iMax, iMin, iMid);
				default:
					return Color.FromArgb(alpha, iMax, iMid, iMin);
			}
		}

		static Color incrementHsb(Color i, float hue, float sat, float brightness)
		{
			return FromAhsb(i.A, (i.GetHue() + hue) % 360f, Min(i.GetSaturation() + sat, 1f), Min(i.GetBrightness() + brightness, 1f));
		}

		public Form1()
		{
			InitializeComponent();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			finalImage.Save(textBox1.Text);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			workingImage = (Bitmap)Image.FromFile(textBox1.Text);
			button4_Click(sender, e);
		}

		void rgbManager()
		{
			for (int y = 0; y < finalImage.Height; y++)
			{
				for (int x = 0; x < finalImage.Width; x++)
				{
					finalImage.SetPixel(
						x, y,
						incrementRgb(
							finalImage.GetPixel(x, y),
							rBar.Value, gBar.Value, bBar.Value));
				}
			}

			Debug.WriteLine("rgbmanager done");
		}
		void hsbManager()
		{
			for (int y = 0; y < finalImage.Height; y++)
			{
				for (int x = 0; x < finalImage.Width; x++)
				{
					finalImage.SetPixel(
						x, y,
						incrementHsb(
							finalImage.GetPixel(x, y),
							hueBar.Value, satBar.Value/100f, brightBar.Value/100f));
				}
			}

			Debug.WriteLine("hsbmanager done");
		}

		private void button3_Click(object sender, EventArgs e)
		{
			finalImage = (Bitmap)workingImage.Clone();
			if (!(rBar.Value == 0 && gBar.Value == 0 && bBar.Value == 0)) rgbManager();
			if (!(hueBar.Value == 0 && satBar.Value == 0 && brightBar.Value == 0)) hsbManager();
			pictureBox1.BackgroundImage = (Bitmap)finalImage.Clone();
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

			hueBar.Value = 0; hueBar_Scroll(sender, e);
			satBar.Value = 0; satBar_Scroll(sender, e);
			brightBar.Value = 0; brightBar_Scroll(sender, e);
		}

		private void hueBar_Scroll(object sender, EventArgs e)
		{
			label5.Text = hueBar.Value.ToString() + "°";
		}

		private void satBar_Scroll(object sender, EventArgs e)
		{
			label6.Text = satBar.Value.ToString() + "%";
		}

		private void brightBar_Scroll(object sender, EventArgs e)
		{
			label7.Text = brightBar.Value.ToString() + "%";
		}
	}
}