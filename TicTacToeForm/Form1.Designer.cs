namespace TicTacToeForm
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
			tableLayoutPanel1 = new TableLayoutPanel();
			label1 = new Label();
			label3 = new Label();
			label4 = new Label();
			label5 = new Label();
			label6 = new Label();
			label7 = new Label();
			label8 = new Label();
			label9 = new Label();
			label2 = new Label();
			tableLayoutPanel1.SuspendLayout();
			SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.BackColor = SystemColors.Highlight;
			tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;
			tableLayoutPanel1.ColumnCount = 3;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
			tableLayoutPanel1.Controls.Add(label1, 0, 0);
			tableLayoutPanel1.Controls.Add(label3, 2, 0);
			tableLayoutPanel1.Controls.Add(label4, 0, 1);
			tableLayoutPanel1.Controls.Add(label5, 1, 1);
			tableLayoutPanel1.Controls.Add(label6, 2, 1);
			tableLayoutPanel1.Controls.Add(label7, 0, 2);
			tableLayoutPanel1.Controls.Add(label8, 1, 2);
			tableLayoutPanel1.Controls.Add(label9, 2, 2);
			tableLayoutPanel1.Controls.Add(label2, 1, 0);
			tableLayoutPanel1.Dock = DockStyle.Fill;
			tableLayoutPanel1.Location = new Point(0, 0);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 3;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333359F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333359F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
			tableLayoutPanel1.Size = new Size(442, 460);
			tableLayoutPanel1.TabIndex = 0;
			tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
			// 
			// label1
			// 
			label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
			label1.Location = new Point(5, 2);
			label1.Name = "label1";
			label1.Size = new Size(138, 150);
			label1.TabIndex = 0;
			label1.Text = "1";
			label1.TextAlign = ContentAlignment.MiddleCenter;
			label1.Click += label1_Click;
			// 
			// label3
			// 
			label3.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
			label3.Location = new Point(297, 2);
			label3.Name = "label3";
			label3.Size = new Size(140, 150);
			label3.TabIndex = 2;
			label3.Text = "3";
			label3.TextAlign = ContentAlignment.MiddleCenter;
			label3.Click += label3_Click;
			// 
			// label4
			// 
			label4.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
			label4.Location = new Point(5, 154);
			label4.Name = "label4";
			label4.Size = new Size(138, 150);
			label4.TabIndex = 3;
			label4.Text = "4";
			label4.TextAlign = ContentAlignment.MiddleCenter;
			label4.Click += label4_Click;
			// 
			// label5
			// 
			label5.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
			label5.Location = new Point(151, 154);
			label5.Name = "label5";
			label5.Size = new Size(138, 150);
			label5.TabIndex = 4;
			label5.Text = "5";
			label5.TextAlign = ContentAlignment.MiddleCenter;
			label5.Click += label5_Click;
			// 
			// label6
			// 
			label6.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
			label6.Location = new Point(297, 154);
			label6.Name = "label6";
			label6.Size = new Size(140, 150);
			label6.TabIndex = 5;
			label6.Text = "6";
			label6.TextAlign = ContentAlignment.MiddleCenter;
			label6.Click += label6_Click;
			// 
			// label7
			// 
			label7.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
			label7.Location = new Point(5, 306);
			label7.Name = "label7";
			label7.Size = new Size(138, 152);
			label7.TabIndex = 6;
			label7.Text = "7";
			label7.TextAlign = ContentAlignment.MiddleCenter;
			label7.Click += label7_Click;
			// 
			// label8
			// 
			label8.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
			label8.Location = new Point(151, 306);
			label8.Name = "label8";
			label8.Size = new Size(138, 152);
			label8.TabIndex = 7;
			label8.Text = "8";
			label8.TextAlign = ContentAlignment.MiddleCenter;
			label8.Click += label8_Click;
			// 
			// label9
			// 
			label9.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
			label9.Location = new Point(297, 306);
			label9.Name = "label9";
			label9.Size = new Size(140, 152);
			label9.TabIndex = 8;
			label9.Text = "9";
			label9.TextAlign = ContentAlignment.MiddleCenter;
			label9.Click += label9_Click;
			// 
			// label2
			// 
			label2.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
			label2.Location = new Point(151, 2);
			label2.Name = "label2";
			label2.Size = new Size(138, 150);
			label2.TabIndex = 1;
			label2.Text = "2";
			label2.TextAlign = ContentAlignment.MiddleCenter;
			label2.Click += label2_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(442, 460);
			Controls.Add(tableLayoutPanel1);
			Name = "Form1";
			Text = "Form1";
			tableLayoutPanel1.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private TableLayoutPanel tableLayoutPanel1;
		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private Label label5;
		private Label label6;
		private Label label7;
		private Label label8;
		private Label label9;
	}
}
