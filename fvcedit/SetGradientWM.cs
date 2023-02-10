using System.Drawing.Drawing2D;

namespace fvcedit
{
	public partial class SetGradientWM : Form
	{
		public WrapMode mode;
		public SetGradientWM()
		{
			InitializeComponent();
			wrapChange(this, new());
		}

		private void button1_Click(object sender, EventArgs e)
			=> Close();

		private void wrapChange(object sender, EventArgs e)
		{
			if (tile.Checked) mode = WrapMode.Tile;
			if (tilefx.Checked) mode = WrapMode.TileFlipX;
			if (tilefy.Checked) mode = WrapMode.TileFlipY;
			if (tilefxy.Checked) mode = WrapMode.TileFlipXY;
		}
	}
}
