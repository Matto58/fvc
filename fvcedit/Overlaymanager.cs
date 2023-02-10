namespace fvcedit
{
	public class Overlaymanager
	{
		public static Func<Bitmap, Point, Font, Color, string, Bitmap>
			drawText = (bmp, loc, font, color, str) =>
			{
				Bitmap b = (Bitmap)bmp.Clone();
				Graphics g = Graphics.FromImage(b);
				SolidBrush brush = new(color);
				g.DrawString(str, font, brush, loc);
				return b;
			};
	}
}