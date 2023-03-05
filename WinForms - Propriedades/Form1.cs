namespace WinForms___Propriedades
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void buttonMain_Click(object sender, EventArgs e)
		{
			buttonMain.Text = "OK";
			buttonMain.BackColor = Color.Tomato;
		}
	}
}