namespace WinForms___Propriedades
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			buttonMain = new Button();
			SuspendLayout();
			// 
			// buttonMain
			// 
			buttonMain.AutoEllipsis = true;
			buttonMain.BackColor = SystemColors.GradientInactiveCaption;
			buttonMain.BackgroundImageLayout = ImageLayout.None;
			buttonMain.Cursor = Cursors.Hand;
			buttonMain.Font = new Font("Vivaldi", 50F, FontStyle.Regular, GraphicsUnit.Point);
			buttonMain.Location = new Point(264, 126);
			buttonMain.Margin = new Padding(10);
			buttonMain.Name = "buttonMain";
			buttonMain.Padding = new Padding(10);
			buttonMain.Size = new Size(309, 164);
			buttonMain.TabIndex = 0;
			buttonMain.Text = "Butão";
			buttonMain.UseCompatibleTextRendering = true;
			buttonMain.UseVisualStyleBackColor = false;
			buttonMain.Click += buttonMain_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(buttonMain);
			Name = "Form1";
			Padding = new Padding(10);
			Text = "Form1";
			ResumeLayout(false);
		}

		#endregion

		private Button buttonMain;
	}
}