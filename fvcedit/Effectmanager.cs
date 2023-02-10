namespace fvcedit
{
	public class Effectmanager
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
}