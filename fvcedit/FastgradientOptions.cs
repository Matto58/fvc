namespace fvcedit
{
	public partial class FastgradientOptions : Form
	{
		public Point pointA, pointB;
		public FastgradientOptions()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			fgColorA.ShowDialog();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			fgColorB.ShowDialog();
		}

		private void button3_Click(object sender, EventArgs e)
			=> Close();

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			try
			{
				pointA.X = int.Parse(textBox1.Text);
			}
			catch
			{
				textBox1.Text = pointA.X.ToString();
			}
		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{
			try
			{
				pointA.Y = int.Parse(textBox2.Text);
			}
			catch
			{
				textBox2.Text = pointA.Y.ToString();
			}
		}

		private void textBox4_TextChanged(object sender, EventArgs e)
		{
			try
			{
				pointB.X = int.Parse(textBox4.Text);
			}
			catch
			{
				textBox4.Text = pointB.X.ToString();
			}
		}

		private void textBox3_TextChanged(object sender, EventArgs e)
		{
			try
			{
				pointB.Y = int.Parse(textBox3.Text);
			}
			catch
			{
				textBox3.Text = pointB.Y.ToString();
			}
		}

	}
}
