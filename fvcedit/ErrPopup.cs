namespace fvcedit
{
	public partial class ErrPopup : Form
	{
		public ErrPopup(string txt, string? stackTrace)
		{
			InitializeComponent();
			label1.Text = txt;
			if (stackTrace != null) textBox1.Text = stackTrace;
		}

		private void button1_Click(object sender, EventArgs e)
			=> Close();
	}
}
