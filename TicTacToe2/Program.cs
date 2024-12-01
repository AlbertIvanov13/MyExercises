
using System.Reflection.PortableExecutable;

string[] positions = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" };


Console.WriteLine("     |     |     ");
Console.WriteLine($"  {positions[0]}  |  {positions[1]}  |  {positions[2]}  ");
Console.WriteLine("_____|_____|_____");
Console.WriteLine("     |     |     ");
Console.WriteLine($"  {positions[3]}  |  {positions[4]}  |  {positions[5]}  ");
Console.WriteLine("_____|_____|_____");
Console.WriteLine("     |     |     ");
Console.WriteLine($"  {positions[6]}  |  {positions[7]}  |  {positions[8]}  ");
Console.WriteLine("     |     |     ");
void DrawFigure(string position1, string position2, string position3, string position4, string position5, string position6, string position7, string position8, string position9)
{
	positions[0] = position1;
	positions[1] = position2;
	positions[2] = position3;
	positions[3] = position4;
	positions[4] = position5;
	positions[5] = position6;
	positions[6] = position7;
	positions[7] = position8;
	positions[8] = position9;
	Console.WriteLine("     |     |     ");
	Console.WriteLine($"  {positions[0]}  |  {positions[1]}  |  {positions[2]}  ");
	Console.WriteLine("_____|_____|_____");
	Console.WriteLine("     |     |     ");
	Console.WriteLine($"  {positions[3]}  |  {positions[4]}  |  {positions[5]}  ");
	Console.WriteLine("_____|_____|_____");
	Console.WriteLine("     |     |     ");
	Console.WriteLine($"  {positions[6]}  |  {positions[7]}  |  {positions[8]}  ");
	Console.WriteLine("     |     |     ");
}

bool isPlayer1 = true;
bool isPlayer2 = true;

void PlayerOne()
{
	isPlayer1 = true;
	while (isPlayer1)
	{
		string formX = "X";

		for (int i = 0; i < positions.Length; i++)
		{
			string choice = Console.ReadLine();

			string pos1 = positions[0];
			string pos2 = positions[1];
			string pos3 = positions[2];
			string pos4 = positions[3];
			string pos5 = positions[4];
			string pos6 = positions[5];
			string pos7 = positions[6];
			string pos8 = positions[7];
			string pos9 = positions[8];

			switch (choice)
			{
				case "1":
					void ReplaceValue1(string newValue)
					{
						pos1 = newValue;
					}
					ReplaceValue1("X");
					DrawFigure(pos1, pos2, pos3, pos4, pos5, pos6, pos7, pos8, pos9);
					isPlayer1 = false;
					List<string> deletePos1 = new List<string>(positions);
					deletePos1.Remove(pos1);
					break;
				case "2":
					void ReplaceValue2(string newValue)
					{
						pos2 = newValue;
					}
					ReplaceValue2("X");
					DrawFigure(pos1, pos2, pos3, pos4, pos5, pos6, pos7, pos8, pos9);
					List<string> deletePos2 = new List<string>(positions);
					deletePos2.Remove(pos2);
					isPlayer1 = false;
					break;
				case "3":
					void ReplaceValue3(string newValue)
					{
						pos3 = newValue;
					}
					ReplaceValue3("X");
					DrawFigure(pos1, pos2, pos3, pos4, pos5, pos6, pos7, pos8, pos9);
					isPlayer1 = false;
					List<string> deletePos3 = new List<string>(positions);
					deletePos3.Remove(pos3);
					break;
				case "4":
					void ReplaceValue4(string newValue)
					{
						pos4 = newValue;
					}
					ReplaceValue4("X");
					DrawFigure(pos1, pos2, pos3, pos4, pos5, pos6, pos7, pos8, pos9);
					isPlayer1 = false;
					List<string> deletePos4 = new List<string>(positions);
					deletePos4.Remove(pos4);
					break;
				case "5":
					void ReplaceValue5(string newValue)
					{
						pos5 = newValue;
					}
					ReplaceValue5("X");
					DrawFigure(pos1, pos2, pos3, pos4, pos5, pos6, pos7, pos8, pos9);
					isPlayer1 = false;
					List<string> deletePos5 = new List<string>(positions);
					deletePos5.Remove(pos5);
					break;
				case "6":
					void ReplaceValue6(string newValue)
					{
						pos6 = newValue;
					}
					ReplaceValue6("X");
					DrawFigure(pos1, pos2, pos3, pos4, pos5, pos6, pos7, pos8, pos9);
					isPlayer1 = false;
					List<string> deletePos6 = new List<string>(positions);
					deletePos6.Remove(pos6);
					break;
				case "7":
					void ReplaceValue7(string newValue)
					{
						pos7 = newValue;
					}
					ReplaceValue7("X");
					DrawFigure(pos1, pos2, pos3, pos4, pos5, pos6, pos7, pos8, pos9);
					isPlayer1 = false;
					List<string> deletePos7 = new List<string>(positions);
					deletePos7.Remove(pos7);
					break;
				case "8":
					void ReplaceValue8(string newValue)
					{
						pos8 = newValue;
					}
					ReplaceValue8("X");
					DrawFigure(pos1, pos2, pos3, pos4, pos5, pos6, pos7, pos8, pos9);
					isPlayer1 = false;
					List<string> deletePos8 = new List<string>(positions);
					deletePos8.Remove(pos8);
					break;
				case "9":
					void ReplaceValue9(string newValue)
					{
						pos9 = newValue;
					}
					ReplaceValue9("X");
					DrawFigure(pos1, pos2, pos3, pos4, pos5, pos6, pos7, pos8, pos9);
					isPlayer1 = false;
					List<string> deletePos9 = new List<string>(positions);
					deletePos9.Remove(pos9);
					break;
				default:
					break;
			}
			break;
		}
	}
}

void PlayerTwo()
{
	isPlayer2 = true;
	while (isPlayer2)
	{
		string formO = "O";

		for (int i = 0; i < positions.Length; i++)
		{
			string choice = Console.ReadLine();

			string pos1 = positions[0];
			string pos2 = positions[1];
			string pos3 = positions[2];
			string pos4 = positions[3];
			string pos5 = positions[4];
			string pos6 = positions[5];
			string pos7 = positions[6];
			string pos8 = positions[7];
			string pos9 = positions[8];

			switch (choice)
			{
				case "1":
					void ReplaceValue1(string newValue)
					{
						pos1 = newValue;
					}
					ReplaceValue1("O");
					//pos1.Replace("1", "X");
					DrawFigure(pos1, pos2, pos3, pos4, pos5, pos6, pos7, pos8, pos9);
					isPlayer2 = false;
					List<string> deletePos1 = new List<string>(positions);
					deletePos1.Remove(pos1);
					break;
				case "2":
					void ReplaceValue2(string newValue)
					{
						pos2 = newValue;
					}
					ReplaceValue2("O");
					//pos1.Replace("1", "X");
					DrawFigure(pos1, pos2, pos3, pos4, pos5, pos6, pos7, pos8, pos9);
					isPlayer2 = false;
					List<string> deletePos2 = new List<string>(positions);
					deletePos2.Remove(pos2);
					break;
				case "3":
					void ReplaceValue3(string newValue)
					{
						pos3 = newValue;
					}
					ReplaceValue3("O");
					//pos1.Replace("1", "X");
					DrawFigure(pos1, pos2, pos3, pos4, pos5, pos6, pos7, pos8, pos9);
					isPlayer2 = false;
					List<string> deletePos3 = new List<string>(positions);
					deletePos3.Remove(pos3);
					break;
				case "4":
					void ReplaceValue4(string newValue)
					{
						pos4 = newValue;
					}
					ReplaceValue4("O");
					//pos1.Replace("1", "X");
					DrawFigure(pos1, pos2, pos3, pos4, pos5, pos6, pos7, pos8, pos9);
					isPlayer2 = false;
					List<string> deletePos4 = new List<string>(positions);
					deletePos4.Remove(pos4);
					break;
				case "5":
					void ReplaceValue5(string newValue)
					{
						pos5 = newValue;
					}
					ReplaceValue5("O");
					//pos1.Replace("1", "X");
					DrawFigure(pos1, pos2, pos3, pos4, pos5, pos6, pos7, pos8, pos9);
					isPlayer2 = false;
					List<string> deletePos5 = new List<string>(positions);
					deletePos5.Remove(pos5);
					break;
				case "6":
					void ReplaceValue6(string newValue)
					{
						pos6 = newValue;
					}
					ReplaceValue6("O");
					//pos1.Replace("1", "X");
					DrawFigure(pos1, pos2, pos3, pos4, pos5, pos6, pos7, pos8, pos9);
					isPlayer2 = false;
					List<string> deletePos6 = new List<string>(positions);
					deletePos6.Remove(pos6);
					break;
				case "7":
					void ReplaceValue7(string newValue)
					{
						pos7 = newValue;
					}
					ReplaceValue7("O");
					//pos1.Replace("1", "X");
					DrawFigure(pos1, pos2, pos3, pos4, pos5, pos6, pos7, pos8, pos9);
					isPlayer2 = false;
					List<string> deletePos7 = new List<string>(positions);
					deletePos7.Remove(pos7);
					break;
				case "8":
					void ReplaceValue8(string newValue)
					{
						pos8 = newValue;
					}
					ReplaceValue8("O");
					//pos1.Replace("1", "X");
					DrawFigure(pos1, pos2, pos3, pos4, pos5, pos6, pos7, pos8, pos9);
					isPlayer2 = false;
					List<string> deletePos8 = new List<string>(positions);
					deletePos8.Remove(pos8);
					break;
				case "9":
					void ReplaceValue9(string newValue)
					{
						pos9 = newValue;
					}
					ReplaceValue9("O");
					//pos1.Replace("1", "X");
					DrawFigure(pos1, pos2, pos3, pos4, pos5, pos6, pos7, pos8, pos9);
					isPlayer2 = false;
					List<string> deletePos9 = new List<string>(positions);
					deletePos9.Remove(pos9);
					break;
				default:
					break;
			}
			break;
		}
	}
}

while (isPlayer1)
{
	string formX = "X";

	for (int i = 0; i < positions.Length; i++)
	{
		string choice = Console.ReadLine();

		string pos1 = positions[0];
		string pos2 = positions[1];
		string pos3 = positions[2];
		string pos4 = positions[3];
		string pos5 = positions[4];
		string pos6 = positions[5];
		string pos7 = positions[6];
		string pos8 = positions[7];
		string pos9 = positions[8];

		switch (choice)
		{
			case "1":
				void ReplaceValue1(string newValue)
				{
					pos1 = newValue;
				}
				ReplaceValue1("X");
				DrawFigure(pos1, pos2, pos3, pos4, pos5, pos6, pos7, pos8, pos9);
				isPlayer1 = false;
				List<string> deletePos1 = new List<string>(positions);
				deletePos1.Remove(pos1);
				positions = deletePos1.ToArray();
				isPlayer1 = false;
				break;
			case "2":
				void ReplaceValue2(string newValue)
				{
					pos2 = newValue;
				}
				ReplaceValue2("X");
				DrawFigure(pos1, pos2, pos3, pos4, pos5, pos6, pos7, pos8, pos9);
				isPlayer1 = false;
				List<string> deletePos2 = new List<string>(positions);
				deletePos2.Remove(pos2);
				break;
			case "3":
				void ReplaceValue3(string newValue)
				{
					pos3 = newValue;
				}
				ReplaceValue3("X");
				DrawFigure(pos1, pos2, pos3, pos4, pos5, pos6, pos7, pos8, pos9);
				isPlayer1 = false;
				List<string> deletePos3 = new List<string>(positions);
				deletePos3.Remove(pos3);
				break;
			case "4":
				void ReplaceValue4(string newValue)
				{
					pos4 = newValue;
				}
				ReplaceValue4("X");
				DrawFigure(pos1, pos2, pos3, pos4, pos5, pos6, pos7, pos8, pos9);
				isPlayer1 = false;
				List<string> deletePos4 = new List<string>(positions);
				deletePos4.Remove(pos4);
				break;
			case "5":
				void ReplaceValue5(string newValue)
				{
					pos5 = newValue;
				}
				ReplaceValue5("X");
				DrawFigure(pos1, pos2, pos3, pos4, pos5, pos6, pos7, pos8, pos9);
				isPlayer1 = false;
				List<string> deletePos5 = new List<string>(positions);
				deletePos5.Remove(pos5);
				break;
			case "6":
				void ReplaceValue6(string newValue)
				{
					pos6 = newValue;
				}
				ReplaceValue6("X");
				DrawFigure(pos1, pos2, pos3, pos4, pos5, pos6, pos7, pos8, pos9);
				isPlayer1 = false;
				List<string> deletePos6 = new List<string>(positions);
				deletePos6.Remove(pos6);
				break;
			case "7":
				void ReplaceValue7(string newValue)
				{
					pos7 = newValue;
				}
				ReplaceValue7("X");
				DrawFigure(pos1, pos2, pos3, pos4, pos5, pos6, pos7, pos8, pos9);
				isPlayer1 = false;
				List<string> deletePos7 = new List<string>(positions);
				deletePos7.Remove(pos7);
				break;
			case "8":
				void ReplaceValue8(string newValue)
				{
					pos8 = newValue;
				}
				ReplaceValue8("X");
				DrawFigure(pos1, pos2, pos3, pos4, pos5, pos6, pos7, pos8, pos9);
				isPlayer1 = false;
				List<string> deletePos8 = new List<string>(positions);
				deletePos8.Remove(pos8);
				break;
			case "9":
				void ReplaceValue9(string newValue)
				{
					pos9 = newValue;
				}
				ReplaceValue9("X");
				DrawFigure(pos1, pos2, pos3, pos4, pos5, pos6, pos7, pos8, pos9);
				isPlayer1 = false;
				List<string> deletePos9 = new List<string>(positions);
				deletePos9.Remove(pos9);
				break;
			default:
				break;
		}
		break;
	}
}

while (isPlayer2)
{
	string formO = "O";

	for (int i = 0; i < positions.Length; i++)
	{
		string choice = Console.ReadLine();

		string pos1 = string.Empty;
		string pos2 = string.Empty;
		string pos3 = string.Empty;
		string pos4 = string.Empty;
		string pos5 = string.Empty;
		string pos6 = string.Empty;
		string pos7 = string.Empty;
		string pos8 = string.Empty;
		string pos9 = string.Empty;

		if (positions.Contains(positions[0]))
		{
			pos1 = positions[0];
		}
		else if (positions.Contains(positions[1]))
        {
			pos2 = positions[1];
		}
		else if (positions.Contains(positions[2]))
		{
			pos3 = positions[2];
		}
		else if (positions.Contains(positions[3]))
		{
			pos4 = positions[3];
		}
		else if(positions.Contains(positions[4]))
		{
			pos5 = positions[4];
		}
		else if (positions.Contains(positions[5]))
		{
			pos6 = positions[5];
		}
		else if (positions.Contains(positions[6]))
		{
			pos7 = positions[6];
		}
		else if (positions.Contains(positions[7]))
		{
			pos8 = positions[7];
		}
		else if (positions.Contains(positions[8]))
		{
			pos9 = positions[8];
		}

		switch (choice)
		{
			case "1":
				void ReplaceValue1(string newValue)
				{
					pos1 = newValue;
				}
				ReplaceValue1("O");
				//pos1.Replace("1", "X");
				DrawFigure(pos1, pos2, pos3, pos4, pos5, pos6, pos7, pos8, pos9);
				isPlayer2 = false;
				List<string> deletePos1 = new List<string>(positions);
				deletePos1.Remove(pos1);
				break;
			case "2":
				void ReplaceValue2(string newValue)
				{
					pos2 = newValue;
				}
				ReplaceValue2("O");
				//pos1.Replace("1", "X");
				DrawFigure(pos1, pos2, pos3, pos4, pos5, pos6, pos7, pos8, pos9);
				isPlayer2 = false;
				List<string> deletePos2 = new List<string>(positions);
				deletePos2.Remove(pos2);
				break;
			case "3":
				void ReplaceValue3(string newValue)
				{
					pos3 = newValue;
				}
				ReplaceValue3("O");
				//pos1.Replace("1", "X");
				DrawFigure(pos1, pos2, pos3, pos4, pos5, pos6, pos7, pos8, pos9);
				isPlayer2 = false;
				List<string> deletePos3 = new List<string>(positions);
				deletePos3.Remove(pos3);
				break;
			case "4":
				void ReplaceValue4(string newValue)
				{
					pos4 = newValue;
				}
				ReplaceValue4("O");
				//pos1.Replace("1", "X");
				DrawFigure(pos1, pos2, pos3, pos4, pos5, pos6, pos7, pos8, pos9);
				isPlayer2 = false;
				List<string> deletePos4 = new List<string>(positions);
				deletePos4.Remove(pos4);
				break;
			case "5":
				void ReplaceValue5(string newValue)
				{
					pos5 = newValue;
				}
				ReplaceValue5("O");
				//pos1.Replace("1", "X");
				DrawFigure(pos1, pos2, pos3, pos4, pos5, pos6, pos7, pos8, pos9);
				isPlayer2 = false;
				List<string> deletePos5 = new List<string>(positions);
				deletePos5.Remove(pos5);
				break;
			case "6":
				void ReplaceValue6(string newValue)
				{
					pos6 = newValue;
				}
				ReplaceValue6("O");
				//pos1.Replace("1", "X");
				DrawFigure(pos1, pos2, pos3, pos4, pos5, pos6, pos7, pos8, pos9);
				isPlayer2 = false;
				List<string> deletePos6 = new List<string>(positions);
				deletePos6.Remove(pos6);
				break;
			case "7":
				void ReplaceValue7(string newValue)
				{
					pos7 = newValue;
				}
				ReplaceValue7("O");
				//pos1.Replace("1", "X");
				DrawFigure(pos1, pos2, pos3, pos4, pos5, pos6, pos7, pos8, pos9);
				isPlayer2 = false;
				List<string> deletePos7 = new List<string>(positions);
				deletePos7.Remove(pos7);
				break;
			case "8":
				void ReplaceValue8(string newValue)
				{
					pos8 = newValue;
				}
				ReplaceValue8("O");
				//pos1.Replace("1", "X");
				DrawFigure(pos1, pos2, pos3, pos4, pos5, pos6, pos7, pos8, pos9);
				isPlayer2 = false;
				List<string> deletePos8 = new List<string>(positions);
				deletePos8.Remove(pos8);
				break;
			case "9":
				void ReplaceValue9(string newValue)
				{
					pos9 = newValue;
				}
				ReplaceValue9("O");
				//pos1.Replace("1", "X");
				DrawFigure(pos1, pos2, pos3, pos4, pos5, pos6, pos7, pos8, pos9);
				isPlayer2 = false;
				List<string> deletePos9 = new List<string>(positions);
				deletePos9.Remove(pos9);
				break;
			default:
				break;
		}
		break;
	}
}

for (int i = positions.Length; i >= 4; i--)
{
	if (!isPlayer1)
	{
		PlayerOne();
	}

	if (!isPlayer2)
	{
		PlayerTwo();
	}
}