
using System.Reflection.PortableExecutable;
using System.Xml.Serialization;

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

void DrawFigure()
{
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

for ( int i = 0; i < positions.Length;)
{
	bool isPlayer1 = true; 
	bool isPlayer2 = true;

	while (isPlayer1)
	{

		string characterX = "X";

		string choice = Console.ReadLine();

		switch (choice)
		{
			case "1":
				if (positions[0] == "1")
				{
					void ReplaceValue1(string newValue)
					{
						positions[0] = newValue;
					}
					ReplaceValue1(characterX);
					DrawFigure();
					isPlayer1 = false;
					i++;
					break;
				}
				else
				{
                    Console.WriteLine("Choose another place!");
					break;
				}
			case "2":
                if (positions[1] == "2")
                {
					void ReplaceValue2(string newValue)
					{
						positions[1] = newValue;
					}
					ReplaceValue2(characterX);
					DrawFigure();
					isPlayer1 = false;
					i++;
					break;
				}
				else
				{
                    Console.WriteLine("Choose another place!");
					break;
				}
			case "3":
				if (positions[2] == "3")
				{
					void ReplaceValue3(string newValue)
					{
						positions[2] = newValue;
					}
					ReplaceValue3(characterX);
					DrawFigure();
					isPlayer1 = false;
					i++;
					break;
				}
				else
				{
                    Console.WriteLine("Choose another place!");
					break;
				}
			case "4":
				if (positions[3] == "4")
				{
					void ReplaceValue4(string newValue)
					{
						positions[3] = newValue;
					}
					ReplaceValue4(characterX);
					DrawFigure();
					isPlayer1 = false;
					i++;
					break;
				}
				else
				{
                    Console.WriteLine("Choose another place!");
					break;
				}
			case "5":
				if (positions[4] == "5")
				{
					void ReplaceValue5(string newValue)
					{
						positions[4] = newValue;
					}
					ReplaceValue5(characterX);
					DrawFigure();
					isPlayer1 = false;
					i++;
					break;
				}
				else
				{
                    Console.WriteLine("Choose another place!");
					break;
				}
			case "6":
		        if (positions[5] == "6")
				{
					void ReplaceValue6(string newValue)
					{
						positions[5] = newValue;
					}
					ReplaceValue6(characterX);
					DrawFigure();
					isPlayer1 = false;
					i++;
					break;
				}
				else
				{
                    Console.WriteLine("Choose another place!");
					break;
				}
			case "7":
				if (positions[6] == "7")
				{
					void ReplaceValue7(string newValue)
					{
						positions[6] = newValue;
					}
					ReplaceValue7(characterX);
					DrawFigure();
					isPlayer1 = false;
					i++;
					break;
				}
				else
				{
                    Console.WriteLine("Choose another place!");
					break;
				}
			case "8":
				if (positions[7] == "8")
				{
					void ReplaceValue8(string newValue)
					{
						positions[7] = newValue;
					}
					ReplaceValue8(characterX);
					DrawFigure();
					isPlayer1 = false;
					i++;
					break;
				}
				else
				{
                    Console.WriteLine("Choose another place!");
					break;
				}
			case "9":
				if (positions[8] == "9")
				{
					void ReplaceValue9(string newValue)
					{
						positions[8] = newValue;
					}
					ReplaceValue9(characterX);
					DrawFigure();
					isPlayer1 = false;
					i++;
					break;
				}
				else
				{
                    Console.WriteLine("Choose another place!");
					break;
				}
		}
		if (positions[0] == "X" && positions[1] == "X" && positions[2] == "X")
		{
			Console.WriteLine("Player 1 won!!!");
			Environment.Exit(0);
		}
		else if (positions[3] == "X" && positions[4] == "X" && positions[5] == "X")
		{
			Console.WriteLine("Player 1 won!!!");
			Environment.Exit(0);
		}
		else if (positions[6] == "X" && positions[7] == "X" && positions[8] == "X")
		{
			Console.WriteLine("Player 1 won!!!");
			Environment.Exit(0);
		}
		else if (positions[0] == "X" && positions[3] == "X" && positions[6] == "X")
		{
			Console.WriteLine("Player 1 won!!!");
			Environment.Exit(0);
		}
		else if (positions[1] == "X" && positions[4] == "X" && positions[7] == "X")
		{
			Console.WriteLine("Player 1 won!!!");
			Environment.Exit(0);
		}
		else if (positions[2] == "X" && positions[5] == "X" && positions[8] == "X")
		{
			Console.WriteLine("Player 1 won!!!");
			Environment.Exit(0);
		}
		else if (positions[0] == "X" && positions[4] == "X" && positions[8] == "X")
		{
			Console.WriteLine("Player 1 won!!!");
			Environment.Exit(0);
		}
		else if (positions[2] == "X" && positions[4] == "X" && positions[6] == "X")
		{
			Console.WriteLine("Player 1 won!!!");
			Environment.Exit(0);
		}
	}

	if (i < 8)
	{
		for (int j = i; j <= i;)
		{
			while (isPlayer2)
			{
				string characterO = "O";

				string choice = Console.ReadLine();

				switch (choice)
				{
					case "1":
						if (positions[0] == "1")
						{
							void ReplaceValue1(string newValue)
							{
								positions[0] = newValue;
							}
							ReplaceValue1(characterO);
							DrawFigure();
							isPlayer2 = false;
							i++;
						}
						else
						{
                            Console.WriteLine("Choose another place!");
							break;
						}
						break;
					case "2":
						if (positions[1] == "2")
						{
							void ReplaceValue2(string newValue)
							{
								positions[1] = newValue;
							}
							ReplaceValue2(characterO);
							DrawFigure();
							isPlayer2 = false;
							i++;
						}
						else
						{
							Console.WriteLine("Choose another place!");
							break;
						}
						break;
					case "3":
						if (positions[2] == "3")
						{
							void ReplaceValue3(string newValue)
							{
								positions[2] = newValue;
							}
							ReplaceValue3(characterO);
							DrawFigure();
							isPlayer2 = false;
							i++;
						}
						else
						{
							Console.WriteLine("Choose another place!");
							break;
						}
						break;
					case "4":
						if (positions[3] == "4")
						{
							void ReplaceValue4(string newValue)
							{
								positions[3] = newValue;
							}
							ReplaceValue4(characterO);
							DrawFigure();
							isPlayer2 = false;
							i++;
						}
						else
						{
							Console.WriteLine("Choose another place!");
							break;
						}
						break;
					case "5":
						if (positions[4] == "5")
						{
							void ReplaceValue5(string newValue)
							{
								positions[4] = newValue;
							}
							ReplaceValue5(characterO);
							DrawFigure();
							isPlayer2 = false;
							i++;
						}
						else
						{
							Console.WriteLine("Choose another place!");
							break;
						}
						break;
					case "6":
						if (positions[5] == "6")
						{
							void ReplaceValue6(string newValue)
							{
								positions[5] = newValue;
							}
							ReplaceValue6(characterO);
							DrawFigure();
							isPlayer2 = false;
							i++;
						}
						else
						{
							Console.WriteLine("Choose another place!");
							break;
						}
						break;
					case "7":
						if (positions[6] == "7")
						{
							void ReplaceValue7(string newValue)
							{
								positions[6] = newValue;
							}
							ReplaceValue7(characterO);
							DrawFigure();
							isPlayer2 = false;
							i++;
						}
						else
						{
							Console.WriteLine("Choose another place!");
							break;
						}
						break;
					case "8":
						if (positions[7] == "8")
						{
							void ReplaceValue8(string newValue)
							{
								positions[7] = newValue;
							}
							ReplaceValue8(characterO);
							DrawFigure();
							isPlayer2 = false;
							i++;
						}
						else
						{
							Console.WriteLine("Choose another place!");
							break;
						}
						break;
					case "9":
						if (positions[8] == "9")
						{
							void ReplaceValue9(string newValue)
							{
								positions[8] = newValue;
							}
							ReplaceValue9(characterO);
							DrawFigure();
							isPlayer2 = false;
							i++;
						}
						else
						{
							Console.WriteLine("Choose another place!");
							break;
						}
						break;
				}
				if (positions[0] == "O" && positions[1] == "O" && positions[2] == "O")
				{
					Console.WriteLine("Player 2 won!!!");
					Environment.Exit(0);
				}
				else if (positions[3] == "O" && positions[4] == "O" && positions[5] == "O")
				{
					Console.WriteLine("Player 2 won!!!");
					Environment.Exit(0);
				}
				else if (positions[6] == "O" && positions[7] == "O" && positions[8] == "O")
				{
					Console.WriteLine("Player 2 won!!!");
					Environment.Exit(0);
				}
				else if (positions[0] == "O" && positions[3] == "O" && positions[6] == "O")
				{
					Console.WriteLine("Player 1 won!!!");
					Environment.Exit(0);
				}
				else if (positions[1] == "O" && positions[4] == "O" && positions[7] == "O")
				{
					Console.WriteLine("Player 2 won!!!");
					Environment.Exit(0);
				}
				else if (positions[2] == "O" && positions[5] == "O" && positions[8] == "O")
				{
					Console.WriteLine("Player 2 won!!!");
					Environment.Exit(0);
				}
				else if (positions[0] == "O" && positions[4] == "O" && positions[8] == "O")
				{
					Console.WriteLine("Player 2 won!!!");
					Environment.Exit(0);
				}
				else if (positions[2] == "O" && positions[4] == "O" && positions[6] == "O")
				{
					Console.WriteLine("Player 2 won!!!");
					Environment.Exit(0);
				}
			}
			break;
		}
	}
}

Console.WriteLine("Tie!!!");