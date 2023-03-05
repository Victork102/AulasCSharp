namespace WinForms___Labels
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
			myLabel = new Label();
			SuspendLayout();
			// 
			// myLabel
			// 
			myLabel.AutoSize = true;
			myLabel.Font = new Font("Vivaldi", 36F, FontStyle.Regular, GraphicsUnit.Point);
			myLabel.ForeColor = Color.DeepSkyBlue;
			myLabel.Location = new Point(128, 98);
			myLabel.Name = "myLabel";
			myLabel.Size = new Size(394, 71);
			myLabel.TabIndex = 0;
			myLabel.Text = "Minha Etiqueta";
			myLabel.Click += myLabel_Click;
			myLabel.DoubleClick += myLabel_DoubleClick;
			myLabel.MouseEnter += myLabel_MouseEnter;
			myLabel.MouseLeave += myLabel_MouseLeave;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(myLabel);
			Name = "Form1";
			Text = "Form1";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label myLabel;
	}
}