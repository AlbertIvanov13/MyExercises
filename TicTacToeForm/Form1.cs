using System.Diagnostics.Metrics;

namespace TicTacToeForm
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		bool isPlayer1 = true;
		bool isPlayer2 = false;
		private void label1_Click(object sender, EventArgs e)
		{
			if (isPlayer1)
			{
				if (label1.Text == "X" || label1.Text == "O")
				{
					MessageBox.Show("Choose another place!");
				}
				else if (label1.Text == "1")
				{
					label1.Text = "X";
					isPlayer2 = true;
					isPlayer1 = false;
					Winner();
				}
			}
			else if (isPlayer2)
			{
				if (label1.Text == "X" || label1.Text == "O")
				{
					MessageBox.Show("Choose another place!");
				}
				else if (label1.Text == "1")
				{
					label1.Text = "O";
					isPlayer2 = false;
					isPlayer1 = true;
					Winner();
				}
			}
		}

		private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{
			if (isPlayer1)
			{
				if (label2.Text == "X" || label2.Text == "O")
				{
					MessageBox.Show("Choose another place!");
				}
				else if (label2.Text == "2")
				{
					label2.Text = "X";
					isPlayer2 = true;
					isPlayer1 = false;
					Winner();
				}
			}
			else if (isPlayer2)
			{
				if (label2.Text == "X" || label2.Text == "O")
				{
					MessageBox.Show("Choose another place!");
				}
				else if (label2.Text == "2")
				{
					label2.Text = "O";
					isPlayer2 = true;
					isPlayer1 = true;
					Winner();
				}
			}
		}

		private void label3_Click(object sender, EventArgs e)
		{
			if (isPlayer1)
			{
				if (label3.Text == "X" || label3.Text == "O")
				{
					MessageBox.Show("Choose another place!");
				}
				else if (label3.Text == "3")
				{
					label3.Text = "X";
					isPlayer2 = true;
					isPlayer1 = false;
					Winner();
				}
			}
			else if (isPlayer2)
			{
				if (label3.Text == "X" || label3.Text == "O")
				{
					MessageBox.Show("Choose another place!");
				}
				else if (label3.Text == "3")
				{
					label3.Text = "O";
					isPlayer2 = false;
					isPlayer1 = true;
					Winner();
				}
			}
		}

		private void label4_Click(object sender, EventArgs e)
		{
			if (isPlayer1)
			{
				if (label4.Text == "X" || label4.Text == "O")
				{
					MessageBox.Show("Choose another place!");
				}
				else if (label4.Text == "4")
				{
					label4.Text = "X";
					isPlayer2 = true;
					isPlayer1 = false;
					Winner();
				}
			}
			else if (isPlayer2)
			{
				if (label4.Text == "X" || label4.Text == "O")
				{
					MessageBox.Show("Choose another place!");
				}
				else if (label4.Text == "4")
				{
					label4.Text = "O";
					isPlayer2 = false;
					isPlayer1 = true;
					Winner();
				}
			}
		}

		private void label5_Click(object sender, EventArgs e)
		{
			if (isPlayer1)
			{
				if (label5.Text == "X" || label5.Text == "O")
				{
					MessageBox.Show("Choose another place!");
				}
				else if (label5.Text == "5")
				{
					label5.Text = "X";
					isPlayer2 = true;
					isPlayer1 = false;
					Winner();
				}
			}
			else if (isPlayer2)
			{
				if (label5.Text == "X" || label5.Text == "O")
				{
					MessageBox.Show("Choose another place!");
				}
				else if (label5.Text == "5")
				{
					label5.Text = "O";
					isPlayer2 = false;
					isPlayer1 = true;
					Winner();
				}
			}
		}

		private void label6_Click(object sender, EventArgs e)
		{
			if (isPlayer1)
			{
				if (label6.Text == "X" || label6.Text == "O")
				{
					MessageBox.Show("Choose another place!");
				}
				else if (label6.Text == "6")
				{
					label6.Text = "X";
					isPlayer2 = true;
					isPlayer1 = false;
					Winner();
				}
			}
			else if (isPlayer2)
			{
				if (label6.Text == "X" || label6.Text == "O")
				{
					MessageBox.Show("Choose another place!");
				}
				else if (label6.Text == "6")
				{
					label6.Text = "O";
					isPlayer2 = false;
					isPlayer1 = true;
					Winner();
				}
			}
		}

		private void label7_Click(object sender, EventArgs e)
		{
			if (isPlayer1)
			{
				if (label7.Text == "X" || label7.Text == "O")
				{
					MessageBox.Show("Choose another place!");
				}
				else if (label7.Text == "7")
				{
					label7.Text = "X";
					isPlayer2 = true;
					isPlayer1 = false;
					Winner();
				}
			}
			else if (isPlayer2)
			{
				if (label7.Text == "X" || label7.Text == "O")
				{
					MessageBox.Show("Choose another place!");
				}
				else if (label7.Text == "7")
				{
					label7.Text = "O";
					isPlayer2 = false;
					isPlayer1 = true;
					Winner();
				}
			}
		}

		private void label8_Click(object sender, EventArgs e)
		{
			if (isPlayer1)
			{
				if (label8.Text == "X" || label8.Text == "O")
				{
					MessageBox.Show("Choose another place!");
				}
				else if (label8.Text == "8")
				{
					label8.Text = "X";
					isPlayer2 = true;
					isPlayer1 = false;
					Winner();
				}
			}
			else if (isPlayer2)
			{
				if (label8.Text == "X" || label8.Text == "O")
				{
					MessageBox.Show("Choose another place!");
				}
				else if (label8.Text == "8")
				{
					label8.Text = "O";
					isPlayer2 = false;
					isPlayer1 = true;
					Winner();
				}
			}
		}

		private void label9_Click(object sender, EventArgs e)
		{
			if (isPlayer1)
			{
				if (label9.Text == "X" || label9.Text == "O")
				{
					MessageBox.Show("Choose another place!");
				}
				else if (label9.Text == "9")
				{
					label9.Text = "X";
					isPlayer2 = true;
					isPlayer1 = false;
					Winner();
				}
			}
			else if (isPlayer2)
			{
				if (label9.Text == "X" || label9.Text == "O")
				{
					MessageBox.Show("Choose another place!");
				}
				else if (label9.Text == "9")
				{
					label9.Text = "O";
					isPlayer2 = false;
					isPlayer1 = true;
					Winner();
				}
			}
		}

		private void Winner()
		{
			if (true)
			{
				if (label1.Text == "X" && label2.Text == "X" && label3.Text == "X")
				{
					MessageBox.Show("Player 1 Won!");
					Environment.Exit(0);
				}
				else if (label4.Text == "X" && label5.Text == "X" && label6.Text == "X")
				{
					MessageBox.Show("Player 1 Won!");
					Environment.Exit(0);
				}
				else if (label7.Text == "X" && label8.Text == "X" && label9.Text == "X")
				{
					MessageBox.Show("Player 1 Won!");
					Environment.Exit(0);
				}
				else if (label1.Text == "X" && label4.Text == "X" && label7.Text == "X")
				{
					MessageBox.Show("Player 1 Won!");
					Environment.Exit(0);
				}
				else if (label2.Text == "X" && label5.Text == "X" && label8.Text == "X")
				{
					MessageBox.Show("Player 1 Won!");
					Environment.Exit(0);
				}
				else if (label3.Text == "X" && label6.Text == "X" && label9.Text == "X")
				{
					MessageBox.Show("Player 1 Won!");
					Environment.Exit(0);
				}
				else if (label1.Text == "X" && label5.Text == "X" && label9.Text == "X")
				{
					MessageBox.Show("Player 1 Won!");
					Environment.Exit(0);
				}
				else if (label3.Text == "X" && label5.Text == "X" && label7.Text == "X")
				{
					MessageBox.Show("Player 1 Won!");
					Environment.Exit(0);
				}

				if (label1.Text == "O" && label2.Text == "O" && label3.Text == "O")
				{
					MessageBox.Show("Player 2 Won!");
					Environment.Exit(0);
				}
				else if (label4.Text == "O" && label5.Text == "O" && label6.Text == "O")
				{
					MessageBox.Show("Player 2 Won!");
					Environment.Exit(0);
				}
				else if (label7.Text == "O" && label8.Text == "O" && label9.Text == "O")
				{
					MessageBox.Show("Player 2 Won!");
					Environment.Exit(0);
				}
				else if (label1.Text == "O" && label4.Text == "O" && label7.Text == "O")
				{
					MessageBox.Show("Player 2 Won!");
					Environment.Exit(0);
				}
				else if (label2.Text == "O" && label5.Text == "O" && label8.Text == "O")
				{
					MessageBox.Show("Player 2 Won!");
					Environment.Exit(0);
				}
				else if (label3.Text == "O" && label6.Text == "O" && label9.Text == "O")
				{
					MessageBox.Show("Player 2 Won!");
					Environment.Exit(0);
				}
				else if (label1.Text == "O" && label5.Text == "O" && label9.Text == "O")
				{
					MessageBox.Show("Player 2 Won!");
					Environment.Exit(0);
				}
				else if (label3.Text == "O" && label5.Text == "O" && label7.Text == "O")
				{
					MessageBox.Show("Player 2 Won!");
					Environment.Exit(0);
				}
			}
		}
	}
}