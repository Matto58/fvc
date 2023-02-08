using System.Diagnostics;
using System.Drawing.Drawing2D;
using static System.Math;

namespace fvcedit
{
	public partial class Form1 : Form
	{
		Bitmap workingImage = new(1, 1);
		Bitmap finalImage = new(1, 1);

		CheckerboardOptions cbOptions = new();
		FastgradientOptions fgOptions = new();

		public static Color incrementRgb(Color i, int r, int g, int b)
		{
			return Color.FromArgb(
				Min(Max(i.R + r, 0), 255),
				Min(Max(i.G + g, 0), 255),
				Min(Max(i.B + b, 0), 255)
			);
		}
		public static Color invert(Color i)
		{
			return Color.FromArgb(
				255 - i.R,
				255 - i.G,
				255 - i.B
			);
		}
		public static Color onebitPx(Color i)
			=> Color.FromArgb(
				(int)Round(i.R / 255f) * 255,
				(int)Round(i.G / 255f) * 255,
				(int)Round(i.B / 255f) * 255
			);


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
		{
			return FromAhsb(i.A, (i.GetHue() + hue) % 360f, Min(i.GetSaturation() + sat, 1f), Min(i.GetBrightness() + brightness, 1f));
		}

		public Form1()
		{
			InitializeComponent();
			comboBox1_SelectedIndexChanged(this, new());
			button4_Click(this, new());
		}

		private void button2_Click(object sender, EventArgs e)
		{
			try
			{
				finalImage.Save(textBox1.Text);
			}
			catch (Exception ex)
			{
				Debug.WriteLine("Error: " + ex.Message);
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
				Debug.WriteLine("Error: " + ex.Message);
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

		private void button12_Click(object sender, EventArgs e)
		{
			try
			{
				DialogResult r1, r2;
				Color c1, c2;
				Point pa, pb;
				Stopwatch s = new();
				Debug.WriteLine($"generating {comboBox1.SelectedItem} started");
				switch (comboBox1.SelectedItem.ToString())
				{
					case "GradientX":
						r1 = gradientColorA.ShowDialog();
						r2 = gradientColorB.ShowDialog();
						c1 = Color.Black; c2 = Color.White;
						if (r1 == DialogResult.OK)
							c1 = gradientColorA.Color;
						if (r2 == DialogResult.OK)
							c2 = gradientColorB.Color;

						s.Start();
						finalImage = Genmanager.gradientX(int.Parse(textBox2.Text), int.Parse(textBox3.Text), c1, c2);
						break;
					case "GradientY":
						r1 = gradientColorA.ShowDialog();
						r2 = gradientColorB.ShowDialog();
						c1 = Color.Black; c2 = Color.White;
						if (r1 == DialogResult.OK)
							c1 = gradientColorA.Color;
						if (r2 == DialogResult.OK)
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
							cbOptions.radioButton2.Checked
						);
						break;
					case "Fastgradient":
						s.Start();
						finalImage = Genmanager.fastGradient(
							int.Parse(textBox2.Text), int.Parse(textBox3.Text),
							fgOptions.pointA, fgOptions.pointB,
							fgOptions.fgColorA.Color, fgOptions.fgColorB.Color
						);
						break;
					case "GradientX-Fast":
						pa = new(0, 0);
						pb = new(int.Parse(textBox2.Text), 0);

						r1 = gradientColorA.ShowDialog();
						r2 = gradientColorB.ShowDialog();

						c1 = Color.Black; c2 = Color.White;

						if (r1 == DialogResult.OK)
							c1 = gradientColorA.Color;
						if (r2 == DialogResult.OK)
							c2 = gradientColorB.Color;

						s.Start();
						finalImage = Genmanager.fastGradient(
							int.Parse(textBox2.Text), int.Parse(textBox3.Text),
							pa, pb,
							c1, c2
						);
						break;
					case "GradientY-Fast":
						pa = new(0, 0);
						pb = new(0, int.Parse(textBox3.Text));

						r1 = gradientColorA.ShowDialog();
						r2 = gradientColorB.ShowDialog();

						c1 = Color.Black; c2 = Color.White;

						if (r1 == DialogResult.OK)
							c1 = gradientColorA.Color;
						if (r2 == DialogResult.OK)
							c2 = gradientColorB.Color;

						s.Start();
						finalImage = Genmanager.fastGradient(
							int.Parse(textBox2.Text), int.Parse(textBox3.Text),
							pa, pb,
							c1, c2
						);
						break;

					case null:
					default:
						break;
				}
				s.Stop();
				Debug.WriteLine($"generating {comboBox1.SelectedItem} finished ({s.ElapsedMilliseconds}ms)");
				pictureBox1.BackgroundImage = (Bitmap)finalImage.Clone();
			}
			catch (Exception ex)
			{
				Debug.WriteLine("Error: " + ex.Message);
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

		private void button13_Click(object sender, EventArgs e)
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
	}

	// https://stackoverflow.com/a/14353572
	public static class ExtensionMethods
	{
		public static decimal Map(this decimal value, decimal fromSource, decimal toSource, decimal fromTarget, decimal toTarget)
		{
			return (value - fromSource) / (toSource - fromSource) * (toTarget - fromTarget) + fromTarget;
		}
	}

	public static class Effectmanager
	{
		public static Func<Bitmap, Bitmap>
			hueshiftX = b =>
			{
				Bitmap o = new(b.Width, b.Height);
				for (int i = 0; i < o.Width; i += o.Width / 360)
				{
					for (int y = 0; y < o.Height; y++)
					{
						for (int x = i; x < o.Width / 360 + i; x++)
						{
							Color px = b.GetPixel(x, y);
							o.SetPixel(x, y, Form1.incrementHsb(px, i, 0, 0));
						}
					}
				}
				return o;
			},
			hueshiftY = b =>
			{
				Bitmap o = new(b.Width, b.Height);
				for (int i = 0; i < o.Height; i += o.Height / 360)
				{
					for (int y = i; y < o.Height / 360 + i; y++)
					{
						for (int x = 0; x < o.Width; x++)
						{
							Color px = b.GetPixel(x, y);
							o.SetPixel(x, y, Form1.incrementHsb(px, i, 0, 0));
						}
					}
				}
				return o;
			},
			invert = b =>
			{
				Bitmap o = new(b.Width, b.Height);
				for (int y = 0; y < b.Height; y++)
				{
					for (int x = 0; x < b.Width; x++)
					{
						o.SetPixel(x, y, Form1.invert(b.GetPixel(x, y)));
					}
				}
				return o;
			},
			brightmap = b =>
			{
				Bitmap o = new(b.Width, b.Height);
				for (int y = 0; y < b.Height; y++)
				{
					for (int x = 0; x < b.Width; x++)
					{
						int color = (int)(b.GetPixel(x, y).GetBrightness() * 255);
						o.SetPixel(x, y, Color.FromArgb(color, color, color));
					}
				}
				return o;
			},
			satmap = b =>
			{
				Bitmap o = new(b.Width, b.Height);
				for (int y = 0; y < b.Height; y++)
				{
					for (int x = 0; x < b.Width; x++)
					{
						int color = (int)(b.GetPixel(x, y).GetSaturation() * 255);
						o.SetPixel(x, y, Color.FromArgb(color, color, color));
					}
				}
				return o;
			},
			huemap = b =>
			{
				Bitmap o = new(b.Width, b.Height);
				for (int y = 0; y < b.Height; y++)
				{
					for (int x = 0; x < b.Width; x++)
					{
						int color = (int)(b.GetPixel(x, y).GetHue() / 360 * 255);
						o.SetPixel(x, y, Color.FromArgb(color, color, color));
					}
				}
				return o;
			},
			onebit = b =>
			{
				Bitmap o = new(b.Width, b.Height);
				for (int y = 0; y < b.Height; y++)
				{
					for (int x = 0; x < b.Width; x++)
					{
						o.SetPixel(x, y, Form1.onebitPx(b.GetPixel(x, y)));
					}
				}
				return o;
			};
	}
	public static class Genmanager
	{
		public static Func<int, int, Color, Color, Bitmap>
			gradientX = (xs, ys, a, b) =>
			{
				Bitmap bmp = new(xs, ys);
				for (int y = 0; y < ys; y++)
				{
					for (int x = 0; x < xs; x++)
					{
						int red = (int)ExtensionMethods.Map(x, 0, xs, a.R, b.R);
						int grn = (int)ExtensionMethods.Map(x, 0, xs, a.G, b.G);
						int blu = (int)ExtensionMethods.Map(x, 0, xs, a.B, b.B);
						Color c = Color.FromArgb(red, grn, blu);
						bmp.SetPixel(x, y, c);
					}
				}

				return bmp;
			},
			gradientY = (xs, ys, a, b) =>
			{
				Bitmap bmp = new(xs, ys);
				for (int y = 0; y < ys; y++)
				{
					for (int x = 0; x < xs; x++)
					{
						int red = (int)ExtensionMethods.Map(y, 0, ys, a.R, b.R);
						int grn = (int)ExtensionMethods.Map(y, 0, ys, a.G, b.G);
						int blu = (int)ExtensionMethods.Map(y, 0, ys, a.B, b.B);
						Color c = Color.FromArgb(red, grn, blu);
						bmp.SetPixel(x, y, c);
					}
				}

				return bmp;
			};
		public static Func<int, int, int, int, Color, Color, bool, Bitmap>
			checkerboard = (xs, ys, xsq, ysq, a, b, revOrder) =>
			{
				Bitmap o = new Bitmap(xs, ys);
				Graphics g = Graphics.FromImage(o);

				for (int y = 0; y < ys; y += ysq)
				{
					for (int x = 0; x < xs; x += xsq)
					{
						int r = revOrder ? 1 : 0;
						Color c = (x / xsq + y / ysq) % 2 == r ? a : b;
						g.FillRectangle(new SolidBrush(c), x, y, xsq, ysq);
					}
				}

				return o;
			};
		public static Func<int, int, Point, Point, Color, Color, Bitmap>
			fastGradient = (xs, ys, p1, p2, a, b) =>
			{
				Bitmap bmp = new(xs, ys);
				Graphics g = Graphics.FromImage(bmp);
				LinearGradientBrush brush = new(p1, p2, a, b);

				g.FillRectangle(brush, 0, 0, xs, ys);

				return bmp;
			};
	}
}