using System.Drawing.Drawing2D;

namespace fvcedit
{
	public class Genmanager
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
		public static Func<int, int, Point, Point, Color, Color, WrapMode, Bitmap>
			fastGradient = (xs, ys, p1, p2, a, b, wrap) =>
			{
				Bitmap bmp = new(xs, ys);
				Graphics g = Graphics.FromImage(bmp);
				LinearGradientBrush brush = new(p1, p2, a, b)
				{
					WrapMode = wrap
				};

				g.FillRectangle(brush, 0, 0, xs, ys);

				return bmp;
			};
	}
}