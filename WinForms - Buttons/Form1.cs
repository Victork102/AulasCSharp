using WinForms___Buttons.Properties;

namespace WinForms___Buttons
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void myButton_Click(object sender, EventArgs e)
		{
			myButton.BackColor = Color.Tomato;
		}

		private void myButton_MouseLeave(object sender, EventArgs e)
		{
			myButton.BackColor = Color.Ivory;
		}

		private void myButton_MouseEnter(object sender, EventArgs e)
		{
			myButton.BackColor = Color.Indigo;
		}
	}
}