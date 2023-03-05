namespace WinForms___Buttons
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			myButton = new Button();
			SuspendLayout();
			// 
			// myButton
			// 
			myButton.BackgroundImage = (Image)resources.GetObject("myButton.BackgroundImage");
			myButton.BackgroundImageLayout = ImageLayout.Zoom;
			myButton.Location = new Point(12, 56);
			myButton.Name = "myButton";
			myButton.Size = new Size(235, 315);
			myButton.TabIndex = 0;
			myButton.UseVisualStyleBackColor = true;
			myButton.Click += myButton_Click;
			myButton.MouseEnter += myButton_MouseEnter;
			myButton.MouseLeave += myButton_MouseLeave;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(myButton);
			Name = "Form1";
			Text = "Form1";
			ResumeLayout(false);
		}

		#endregion

		private Button myButton;
	}
}