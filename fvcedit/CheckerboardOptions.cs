namespace fvcedit
{
	public partial class CheckerboardOptions : Form
	{
		public CheckerboardOptions()
		{
			InitializeComponent();
			refreshColors();
		}

		private void refreshColors()
		{
			pictureBox1.BackColor = cbColorDark.Color;
			pictureBox2.BackColor = cbColorBright.Color;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			cbColorBright.ShowDialog();
			refreshColors();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			cbColorDark.ShowDialog();
			refreshColors();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
