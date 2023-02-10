using System.Diagnostics;
using System.Drawing.Drawing2D;
using static System.Math;

namespace fvcedit
{
	public partial class Form1 : Form
	{
		internal static Bitmap workingImage = new(1, 1);
		internal static Bitmap finalImage = new(1, 1);

		CheckerboardOptions cbOptions = new();
		FastgradientOptions fgOptions = new();
		TextOverlayOptions toOptions = new();
		SetGradientWM wm = new();

		public static Color incrementRgb(Color i, int r, int g, int b, int a)
			=> Color.FromArgb(
				Min(Max(i.A + a, 0), 255),
				Min(Max(i.R + r, 0), 255),
				Min(Max(i.G + g, 0), 255),
				Min(Max(i.B + b, 0), 255)
			);
		public static Color invert(Color i)
			=> Color.FromArgb(
				i.A,
				255 - i.R,
				255 - i.G,
				255 - i.B
			);
		public static Color onebitPx(Color i)
			=> Color.FromArgb(
				(int)Round(i.A / 255f) * 255,
				(int)Round(i.R / 255f) * 255,
				(int)Round(i.G / 255f) * 255,
				(int)Round(i.B / 255f) * 255
			);

		private void button15_Click(object sender, EventArgs e) // add text overlay
		{
			try
			{
				FontStyle style =
					(toOptions.checkBox3.Checked ? FontStyle.Bold : FontStyle.Regular)
					| (toOptions.checkBox2.Checked ? FontStyle.Italic : FontStyle.Regular)
					| (toOptions.checkBox1.Checked ? FontStyle.Underline : FontStyle.Regular)
					| (toOptions.checkBox4.Checked ? FontStyle.Strikeout : FontStyle.Regular);
				finalImage = Overlaymanager.drawText(
					workingImage, new Point(int.Parse(toOptions.textBox6.Text), int.Parse(toOptions.textBox7.Text)),
					new(FontFamily.Families[fontBox.Items.IndexOf(fontBox.Text)], int.Parse(textBox5.Text), style),
					toOptions.overlayTextColor.Color, textBox4.Text);
				pictureBox1.BackgroundImage = (Bitmap)finalImage.Clone();
			}
			catch (Exception ex)
			{
				new ErrPopup(ex.Message, ex.StackTrace).ShowDialog();
			}
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

		public static Color incrementHsb(Color i, float hue, float sat, float brightness)
			=> FromAhsb(i.A, (i.GetHue() + hue) % 360f, Min(i.GetSaturation() + sat, 1f), Min(i.GetBrightness() + brightness, 1f));

		public Form1()
		{
			InitializeComponent();
			comboBox1_SelectedIndexChanged(this, new());
			button4_Click(this, new());
			fontBox.Items.AddRange(FontFamily.Families.Select<FontFamily, object>(font => font.Name).ToArray());
		}

		private void button2_Click(object sender, EventArgs e)
		{
			try
			{
				finalImage.Save(textBox1.Text);
			}
			catch (Exception ex)
			{
				new ErrPopup(ex.Message, ex.StackTrace).ShowDialog();
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				workingImage = (Bitmap)Image.FromFile(textBox1.Text);
			}
			catch (Exception ex)
			{
				new ErrPopup(ex.Message, ex.StackTrace).ShowDialog();
			}
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
							rBar.Value, gBar.Value, bBar.Value, 0));
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

		#region functions
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

		private void button5_Click(object sender, EventArgs e)
		{
			Debug.WriteLine("hueshiftx started");
			finalImage = Effectmanager.hueshiftX(workingImage);
			Debug.WriteLine("hueshiftx finished");
			pictureBox1.BackgroundImage = (Bitmap)finalImage.Clone();
		}

		private void button6_Click(object sender, EventArgs e)
		{
			Debug.WriteLine("hueshifty started");
			finalImage = Effectmanager.hueshiftY(workingImage);
			Debug.WriteLine("hueshifty finished");
			pictureBox1.BackgroundImage = (Bitmap)finalImage.Clone();
		}

		private void button7_Click(object sender, EventArgs e)
		{
			Debug.WriteLine("invert started");
			finalImage = Effectmanager.invert(workingImage);
			Debug.WriteLine("invert finished");
			pictureBox1.BackgroundImage = (Bitmap)finalImage.Clone();
		}

		private void button8_Click(object sender, EventArgs e)
		{
			Debug.WriteLine("brightmap started");
			finalImage = Effectmanager.brightmap(workingImage);
			Debug.WriteLine("brightmap finished");
			pictureBox1.BackgroundImage = (Bitmap)finalImage.Clone();
		}

		private void button9_Click(object sender, EventArgs e)
		{
			Debug.WriteLine("satmap started");
			finalImage = Effectmanager.satmap(workingImage);
			Debug.WriteLine("satmap finished");
			pictureBox1.BackgroundImage = (Bitmap)finalImage.Clone();
		}

		private void button10_Click(object sender, EventArgs e)
		{
			Debug.WriteLine("huemap started");
			finalImage = Effectmanager.huemap(workingImage);
			Debug.WriteLine("huemap finished");
			pictureBox1.BackgroundImage = (Bitmap)finalImage.Clone();
		}

		private void button11_Click(object sender, EventArgs e)
		{
			Debug.WriteLine("onebit started");
			finalImage = Effectmanager.onebit(workingImage);
			Debug.WriteLine("onebit finished");
			pictureBox1.BackgroundImage = (Bitmap)finalImage.Clone();
		}

		private void button12_Click(object sender, EventArgs e) // generate button
		{
			try
			{
				DialogResult r1, r2;
				Color c1, c2;
				Point pa, pb;
				Stopwatch s = new();
				if (comboBox1.SelectedItem != null)
				{
					Debug.WriteLine($"generating {comboBox1.SelectedItem} started");
					switch (comboBox1.SelectedItem.ToString())
					{
						case "GradientX":
							r1 = gradientColorA.ShowDialog();
							r2 = gradientColorB.ShowDialog();

							c1 = gradientColorA.Color;
							c2 = gradientColorB.Color;

							s.Start();
							finalImage = Genmanager.gradientX(int.Parse(textBox2.Text), int.Parse(textBox3.Text), c1, c2);
							break;
						case "GradientY":
							r1 = gradientColorA.ShowDialog();
							r2 = gradientColorB.ShowDialog();

							c1 = gradientColorA.Color;
							c2 = gradientColorB.Color;

							s.Start();
							finalImage = Genmanager.gradientY(int.Parse(textBox2.Text), int.Parse(textBox3.Text), c1, c2);
							break;
						case "Checkerboard":
							s.Start();
							finalImage = Genmanager.checkerboard(
								int.Parse(textBox2.Text), int.Parse(textBox3.Text),
								int.Parse(cbOptions.textBox1.Text), int.Parse(cbOptions.textBox2.Text),
								cbOptions.cbColorDark.Color, cbOptions.cbColorBright.Color,
								cbOptions.radioButton2.Checked);
							break;
						case "Fastgradient":
							wm.ShowDialog();
							//Debug.WriteLine($"{wm.mode}");

							s.Start();
							finalImage = Genmanager.fastGradient(
								int.Parse(textBox2.Text), int.Parse(textBox3.Text),
								fgOptions.pointA, fgOptions.pointB,
								fgOptions.fgColorA.Color, fgOptions.fgColorB.Color,
								wm.mode);
							break;
						case "GradientX-Fast":
							pa = new(0, 0);
							pb = new(int.Parse(textBox2.Text), 0);

							r1 = gradientColorA.ShowDialog();
							r2 = gradientColorB.ShowDialog();

							c1 = gradientColorA.Color;
							c2 = gradientColorB.Color;

							s.Start();
							finalImage = Genmanager.fastGradient(
								int.Parse(textBox2.Text), int.Parse(textBox3.Text),
								pa, pb,
								c1, c2,
								WrapMode.Tile);
							break;
						case "GradientY-Fast":
							pa = new(0, 0);
							pb = new(0, int.Parse(textBox3.Text));

							r1 = gradientColorA.ShowDialog();
							r2 = gradientColorB.ShowDialog();

							c1 = gradientColorA.Color;
							c2 = gradientColorB.Color;

							s.Start();
							finalImage = Genmanager.fastGradient(
								int.Parse(textBox2.Text), int.Parse(textBox3.Text),
								pa, pb,
								c1, c2,
								WrapMode.Tile);
							break;
						case "Solid":
							solidColor.ShowDialog();

							s.Start();
							finalImage = new(int.Parse(textBox2.Text), int.Parse(textBox3.Text));
							Graphics g = Graphics.FromImage(finalImage);
							g.FillRectangle(new SolidBrush(solidColor.Color), 0, 0, finalImage.Width, finalImage.Height);
							break;
					}
					s.Stop();
					Debug.WriteLine($"generating {comboBox1.SelectedItem} finished ({s.ElapsedMilliseconds}ms)");
					pictureBox1.BackgroundImage = (Bitmap)finalImage.Clone();
				}
			}
			catch (Exception ex)
			{
				new ErrPopup(ex.Message, ex.StackTrace).ShowDialog();
			}
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			//Debug.WriteLine(comboBox1.Text);
			button13.Enabled = comboBox1.Text switch
			{
				"Checkerboard" or "Fastgradient" => true,
				_ => false
			};
		}

		private void button13_Click(object sender, EventArgs e) // options button
		{
			switch (comboBox1.Text)
			{
				case "Checkerboard":
					cbOptions.ShowDialog();
					break;
				case "Fastgradient":
					fgOptions.ShowDialog();
					break;
			}
		}

		private void button14_Click(object sender, EventArgs e)
			=> toOptions.ShowDialog();
		#endregion
	}

	// https://stackoverflow.com/a/14353572
	public static class ExtensionMethods
	{
		public static decimal Map(this decimal value, decimal fromSource, decimal toSource, decimal fromTarget, decimal toTarget)
		{
			return (value - fromSource) / (toSource - fromSource) * (toTarget - fromTarget) + fromTarget;
		}
	}
}