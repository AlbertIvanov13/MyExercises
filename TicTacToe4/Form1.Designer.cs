namespace TicTacToe4
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
			btnClickHere = new Button();
			lblHelloWorld = new Label();
			SuspendLayout();
			// 
			// btnClickHere
			// 
			btnClickHere.Location = new Point(230, 255);
			btnClickHere.Name = "btnClickHere";
			btnClickHere.Size = new Size(94, 29);
			btnClickHere.TabIndex = 0;
			btnClickHere.Text = "Click here";
			btnClickHere.UseVisualStyleBackColor = true;
			btnClickHere.Click += btnClickHere_Click;
			// 
			// lblHelloWorld
			// 
			lblHelloWorld.AutoSize = true;
			lblHelloWorld.Location = new Point(255, 192);
			lblHelloWorld.Name = "lblHelloWorld";
			lblHelloWorld.Size = new Size(50, 20);
			lblHelloWorld.TabIndex = 1;
			lblHelloWorld.Text = "label1";
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(lblHelloWorld);
			Controls.Add(btnClickHere);
			Name = "Form1";
			Text = "Form1";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btnClickHere;
		private Label lblHelloWorld;
	}
}
