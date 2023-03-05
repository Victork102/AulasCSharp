namespace WinForms___Labels
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void myLabel_Click(object sender, EventArgs e)
		{
			myLabel.Font = new Font("Arial", 18);
		}

		private void myLabel_DoubleClick(object sender, EventArgs e)
		{
			myLabel.Font = new Font("Vivaldi", 36);
		}

		private void myLabel_MouseEnter(object sender, EventArgs e)
		{
			myLabel.Text = "Oi";
		}

		private void myLabel_MouseLeave(object sender, EventArgs e)
		{
			myLabel.Text = "Minha Etiqueta";
		}
	}
}