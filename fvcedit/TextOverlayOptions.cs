namespace fvcedit
{
	public partial class TextOverlayOptions : Form
	{
		public TextOverlayOptions()
		{
			InitializeComponent();
		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{
			overlayTextColor.ShowDialog();
			pictureBox2.BackColor = overlayTextColor.Color;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
