using Microsoft.CSharp.RuntimeBinder;
using System.Diagnostics;

Console.WriteLine("Welcome to the Movie Ticket Booking System!");

Console.WriteLine("\nAvailable movies:");

string name = string.Empty;

List<string> movies = new List<string> { $"1. {name = "Avengers: Endgame"} - $12",
	"\n2. The Lion King - $10",
	"\n3. Spiderman: No way home - $15",
	"\n4. Toy Story 4 - $8",
	"\n5. Jurassic World - $14\n"};

string[] moviess = new string[6];
moviess[0] = "Avengers: Endgame";
moviess[1] = "The Lion King";
moviess[2] = "Spiderman: No way home";
moviess[3] = "Toy Story 4";
moviess[4] = "Jurassic World";

Console.WriteLine(string.Join("", movies));

Console.Write("Enter movie: ");

int movieNumber = int.Parse(Console.ReadLine());

Console.Write("\nYou selected: ");

switch (movieNumber)
{
	case 1:
		Console.WriteLine(string.Join("", moviess[0]));
		break;
	case 2:
		Console.WriteLine(string.Join("", moviess[1]));
		break;
	case 3:
		Console.WriteLine(string.Join("", moviess[2]));
		break;
	case 4:
		Console.WriteLine(string.Join("", moviess[3]));
		break;
	case 5:
		Console.WriteLine(string.Join("", moviess[4]));
		break;
}

Console.WriteLine("\nAvailable seating: ");

string[] rowA = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };
string[] rowB = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };
string[] rowC = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };
string[] rowD = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };
string[] rowE = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };

Console.Write("\nRow A: ");
string result = "[ " + string.Join(" ", rowA) + " ]";
Console.WriteLine(result);
Console.Write("\nRow B: ");
string result2 = "[ " + string.Join(" ", rowB) + " ]";
Console.WriteLine(result2);
Console.Write("\nRow C: ");
string result3 = "[ " + string.Join(" ", rowC) + " ]";
Console.WriteLine(result3);
Console.Write("\nRow D: ");
string result4 = "[ " + string.Join(" ", rowD) + " ]";
Console.WriteLine(result4);
Console.Write("\nRow E: ");
string result5 = "[ " + string.Join(" ", rowE) + " ]";
Console.WriteLine(result5);

Console.WriteLine("\nPlease select a seat (Enter row letter and seat number, e.g., A5): \n");
string seat = Console.ReadLine();

List<string> rowAA = new List<string>(rowA);
if (seat.StartsWith("A"))
{
	//rowAA = new List<string>(rowA);
	if (seat == "A1")
	{
		for (int i = 0; i < rowAA.Count - 1; i++)
		{
			if (rowAA.Contains("1"))
			{
				rowAA.Remove("1");
				break;
			}
		}
	}
	else if (seat == "A2")
	{
		for (int i = 0; i < rowAA.Count - 1; i++)
		{
			if (rowAA.Contains("2"))
			{
				rowAA.Remove("2");
				break;
			}
		}
	}
	else if (seat == "A3")
	{
		for (int i = 0; i < rowAA.Count - 1; i++)
		{
			if (rowAA.Contains("3"))
			{
				rowAA.Remove("3");
				break;
			}
		}
	}
	else if (seat == "A4")
	{
		for (int i = 0; i < rowAA.Count - 1; i++)
		{
			if (rowAA.Contains("4"))
			{
				rowAA.Remove("4");
				break;
			}
		}
	}
	else if (seat == "A5")
	{
		for (int i = 0; i < rowAA.Count - 1; i++)
		{
			if (rowAA.Contains("5"))
			{
				rowAA.Remove("5");
				break;
			}
		}
	}
	else if (seat == "A6")
	{
		for (int i = 0; i < rowAA.Count - 1; i++)
		{
			if (rowAA.Contains("6"))
			{
				rowAA.Remove("6");
				break;
			}
		}
	}
	else if (seat == "A7")
	{
		for (int i = 0; i < rowAA.Count - 1; i++)
		{
			if (rowAA.Contains("7"))
			{
				rowAA.Remove("7");
				break;
			}
		}
	}
	else if (seat == "A8")
	{
		for (int i = 0; i < rowAA.Count - 1; i++)
		{
			if (rowAA.Contains("8"))
			{
				rowAA.Remove("8");
				break;
			}
		}
	}
	else if (seat == "A9")
	{
		for (int i = 0; i < rowAA.Count - 1; i++)
		{
			if (rowAA.Contains("9"))
			{
				rowAA.Remove("9");
				break;
			}
		}
	}
	else if (seat == "A10")
	{
		for (int i = 0; i < rowAA.Count - 1; i++)
		{
			if (rowAA.Contains("10"))
			{
				rowAA.Remove("10");
				break;
			}
		}
	}
}

List<string> rowBB = new List<string>(rowB);
if (seat.StartsWith("B"))
{
	//rowBB = new List<string>(rowB);
	if (seat == "B1")
	{
		for (int i = 0; i < rowBB.Count - 1; i++)
		{
			if (rowBB.Contains("1"))
			{
				rowBB.Remove("1");
				break;
			}
		}
	}
	else if (seat == "B2")
	{
		for (int i = 0; i < rowBB.Count - 1; i++)
		{
			if (rowBB.Contains("2"))
			{
				rowBB.Remove("2");
				break;
			}
		}
	}
	else if (seat == "B3")
	{
		for (int i = 0; i < rowBB.Count - 1; i++)
		{
			if (rowBB.Contains("3"))
			{
				rowBB.Remove("3");
				break;
			}
		}
	}
	else if (seat == "B4")
	{
		for (int i = 0; i < rowBB.Count - 1; i++)
		{
			if (rowBB.Contains("4"))
			{
				rowBB.Remove("4");
				break;
			}
		}
	}
	else if (seat == "B5")
	{
		for (int i = 0; i < rowBB.Count - 1; i++)
		{
			if (rowBB.Contains("5"))
			{
				rowBB.Remove("5");
				break;
			}
		}
	}
	else if (seat == "B6")
	{
		for (int i = 0; i < rowBB.Count - 1; i++)
		{
			if (rowBB.Contains("6"))
			{
				rowBB.Remove("6");
				break;
			}
		}
	}
	else if (seat == "B7")
	{
		for (int i = 0; i < rowBB.Count - 1; i++)
		{
			if (rowBB.Contains("7"))
			{
				rowBB.Remove("7");
				break;
			}
		}
	}
	else if (seat == "B8")
	{
		for (int i = 0; i < rowBB.Count - 1; i++)
		{
			if (rowBB.Contains("8"))
			{
				rowBB.Remove("8");
				break;
			}
		}
	}
	else if (seat == "B9")
	{
		for (int i = 0; i < rowBB.Count - 1; i++)
		{
			if (rowBB.Contains("9"))
			{
				rowBB.Remove("9");
				break;
			}
		}
	}
	else if (seat == "B10")
	{
		for (int i = 0; i < rowBB.Count - 1; i++)
		{
			if (rowBB.Contains("10"))
			{
				rowBB.Remove("10");
				break;
			}
		}
	}
}

List<string> rowCC = new List<string>(rowC);
if (seat.StartsWith("C"))
{
	//rowCC = new List<string>(rowC);
	if (seat == "C1")
	{
		for (int i = 0; i < rowCC.Count - 1; i++)
		{
			if (rowCC.Contains("1"))
			{
				rowCC.Remove("1");
				break;
			}
		}
	}
	else if (seat == "C2")
	{
		for (int i = 0; i < rowCC.Count - 1; i++)
		{
			if (rowCC.Contains("2"))
			{
				rowCC.Remove("2");
				break;
			}
		}
	}
	else if (seat == "C3")
	{
		for (int i = 0; i < rowCC.Count - 1; i++)
		{
			if (rowCC.Contains("3"))
			{
				rowCC.Remove("3");
				break;
			}
		}
	}
	else if (seat == "C4")
	{
		for (int i = 0; i < rowCC.Count - 1; i++)
		{
			if (rowCC.Contains("4"))
			{
				rowCC.Remove("4");
				break;
			}
		}
	}
	else if (seat == "C5")
	{
		for (int i = 0; i < rowCC.Count - 1; i++)
		{
			if (rowCC.Contains("5"))
			{
				rowCC.Remove("5");
				break;
			}
		}
	}
	else if (seat == "C6")
	{
		for (int i = 0; i < rowCC.Count - 1; i++)
		{
			if (rowCC.Contains("6"))
			{
				rowCC.Remove("6");
				break;
			}
		}
	}
	else if (seat == "C7")
	{
		for (int i = 0; i < rowCC.Count - 1; i++)
		{
			if (rowCC.Contains("7"))
			{
				rowCC.Remove("7");
				break;
			}
		}
	}
	else if (seat == "C8")
	{
		for (int i = 0; i < rowCC.Count - 1; i++)
		{
			if (rowCC.Contains("8"))
			{
				rowCC.Remove("8");
				break;
			}
		}
	}
	else if (seat == "C9")
	{
		for (int i = 0; i < rowCC.Count - 1; i++)
		{
			if (rowCC.Contains("9"))
			{
				rowCC.Remove("9");
				break;
			}
		}
	}
	else if (seat == "C10")
	{
		for (int i = 0; i < rowCC.Count - 1; i++)
		{
			if (rowCC.Contains("10"))
			{
				rowCC.Remove("10");
				break;
			}
		}
	}
}

List<string> rowDD = new List<string>(rowD);
if (seat.StartsWith("D"))
{
	//rowDD = new List<string>(rowD);
	if (seat == "D1")
	{
		for (int i = 0; i < rowDD.Count - 1; i++)
		{
			if (rowDD.Contains("1"))
			{
				rowDD.Remove("1");
				break;
			}
		}
	}
	else if (seat == "D2")
	{
		for (int i = 0; i < rowDD.Count - 1; i++)
		{
			if (rowDD.Contains("2"))
			{
				rowDD.Remove("2");
				break;
			}
		}
	}
	else if (seat == "D3")
	{
		for (int i = 0; i < rowDD.Count - 1; i++)
		{
			if (rowDD.Contains("3"))
			{
				rowDD.Remove("3");
				break;
			}
		}
	}
	else if (seat == "D4")
	{
		for (int i = 0; i < rowDD.Count - 1; i++)
		{
			if (rowDD.Contains("4"))
			{
				rowDD.Remove("4");
				break;
			}
		}
	}
	else if (seat == "D5")
	{
		for (int i = 0; i < rowDD.Count - 1; i++)
		{
			if (rowDD.Contains("5"))
			{
				rowDD.Remove("5");
				break;
			}
		}
	}
	else if (seat == "D6")
	{
		for (int i = 0; i < rowDD.Count - 1; i++)
		{
			if (rowDD.Contains("6"))
			{
				rowDD.Remove("6");
				break;
			}
		}
	}
	else if (seat == "D7")
	{
		for (int i = 0; i < rowDD.Count - 1; i++)
		{
			if (rowDD.Contains("7"))
			{
				rowDD.Remove("7");
				break;
			}
		}
	}
	else if (seat == "D8")
	{
		for (int i = 0; i < rowDD.Count - 1; i++)
		{
			if (rowDD.Contains("8"))
			{
				rowDD.Remove("8");
				break;
			}
		}
	}
	else if (seat == "D9")
	{
		for (int i = 0; i < rowDD.Count - 1; i++)
		{
			if (rowDD.Contains("9"))
			{
				rowDD.Remove("9");
				break;
			}
		}
	}
	else if (seat == "D10")
	{
		for (int i = 0; i < rowDD.Count - 1; i++)
		{
			if (rowDD.Contains("10"))
			{
				rowDD.Remove("10");
				break;
			}
		}
	}
}

List<string> rowEE = new List<string>(rowE);
if (seat.StartsWith("E"))
{
	//rowEE = new List<string>(rowE);
	if (seat == "E1")
	{
		for (int i = 0; i < rowEE.Count - 1; i++)
		{
			if (rowEE.Contains("1"))
			{
				rowEE.Remove("1");
				break;
			}
		}
	}
	else if (seat == "E2")
	{
		for (int i = 0; i < rowEE.Count - 1; i++)
		{
			if (rowEE.Contains("2"))
			{
				rowEE.Remove("2");
				break;
			}
		}
	}
	else if (seat == "E3")
	{
		for (int i = 0; i < rowEE.Count - 1; i++)
		{
			if (rowEE.Contains("3"))
			{
				rowEE.Remove("3");
				break;
			}
		}
	}
	else if (seat == "E4")
	{
		for (int i = 0; i < rowEE.Count - 1; i++)
		{
			if (rowEE.Contains("4"))
			{
				rowEE.Remove("4");
				break;
			}
		}
	}
	else if (seat == "E5")
	{
		for (int i = 0; i < rowEE.Count - 1; i++)
		{
			if (rowEE.Contains("5"))
			{
				rowEE.Remove("5");
				break;
			}
		}
	}
	else if (seat == "E6")
	{
		for (int i = 0; i < rowEE.Count - 1; i++)
		{
			if (rowEE.Contains("6"))
			{
				rowEE.Remove("6");
				break;
			}
		}
	}
	else if (seat == "E7")
	{
		for (int i = 0; i < rowEE.Count - 1; i++)
		{
			if (rowEE.Contains("7"))
			{
				rowEE.Remove("7");
				break;
			}
		}
	}
	else if (seat == "E8")
	{
		for (int i = 0; i < rowEE.Count - 1; i++)
		{
			if (rowEE.Contains("8"))
			{
				rowEE.Remove("8");
				break;
			}
		}
	}
	else if (seat == "E9")
	{
		for (int i = 0; i < rowEE.Count - 1; i++)
		{
			if (rowEE.Contains("9"))
			{
				rowEE.Remove("9");
				break;
			}
		}
	}
	else if (seat == "E10")
	{
		for (int i = 0; i < rowEE.Count - 1; i++)
		{
			if (rowEE.Contains("10"))
			{
				rowEE.Remove("10");
				break;
			}
		}
	}
}

Console.WriteLine("Do you want to book tickets for another movie? (yes/no):\n");
string answer = Console.ReadLine();

void Movies()
{
	Console.WriteLine("\nAvailable movies:");

	string name = string.Empty;

	List<string> movies = new List<string> { $"1. {name = "Avengers: Endgame"} - $12",
	"\n2. The Lion King - $10",
	"\n3. Spiderman: No way home - $15",
	"\n4. Toy Story 4 - $8",
	"\n5. Jurassic World - $14\n"};

	string[] moviess = new string[6];
	moviess[0] = "Avengers: Endgame";
	moviess[1] = "The Lion King";
	moviess[2] = "Spiderman: No way home";
	moviess[3] = "Toy Story 4";
	moviess[4] = "Jurassic World";

	Console.WriteLine(string.Join("", movies));

	Console.Write("Enter movie: ");

	int movieNumber = int.Parse(Console.ReadLine());

	Console.Write("\nYou selected: ");

	switch (movieNumber)
	{
		case 1:
			Console.WriteLine(string.Join("", moviess[0]));
			break;
		case 2:
			Console.WriteLine(string.Join("", moviess[1]));
			break;
		case 3:
			Console.WriteLine(string.Join("", moviess[2]));
			break;
		case 4:
			Console.WriteLine(string.Join("", moviess[3]));
			break;
		case 5:
			Console.WriteLine(string.Join("", moviess[4]));
			break;
	}

	Console.WriteLine("\nAvailable seating: ");

	string[] rowAAA = rowAA.ToArray();
	string[] rowBBB = rowBB.ToArray();
	string[] rowCCC = rowCC.ToArray();
	string[] rowDDD = rowDD.ToArray();
	string[] rowEEE = rowEE.ToArray();

	Console.Write("\nRow A: ");
	string result = "[ " + string.Join(" ", rowAAA) + " ]";
	Console.WriteLine(result);
	Console.Write("\nRow B: ");
	string result2 = "[ " + string.Join(" ", rowBBB) + " ]";
	Console.WriteLine(result2);
	Console.Write("\nRow C: ");
	string result3 = "[ " + string.Join(" ", rowCCC) + " ]";
	Console.WriteLine(result3);
	Console.Write("\nRow D: ");
	string result4 = "[ " + string.Join(" ", rowDDD) + " ]";
	Console.WriteLine(result4);
	Console.Write("\nRow E: ");
	string result5 = "[ " + string.Join(" ", rowEEE) + " ]";
	Console.WriteLine(result5);

	Console.WriteLine("\nPlease select a seat (Enter row letter and seat number, e.g., A5): \n");
	string seat = Console.ReadLine();

	if (seat.StartsWith("A"))
	{
		rowAA = new List<string>(rowAAA);
		if (seat == "A1")
		{
			for (int i = 0; i < rowAA.Count; i++)
			{
				if (rowAA.Contains("1"))
				{
					rowAA.Remove("1");
					break;
				}
			}
		}
		else if (seat == "A2")
		{
			for (int i = 0; i < rowAA.Count; i++)
			{
				if (rowAA.Contains("2"))
				{
					rowAA.Remove("2");
					break;
				}
			}
		}
		else if (seat == "A3")
		{
			for (int i = 0; i < rowAA.Count; i++)
			{
				if (rowAA.Contains("3"))
				{
					rowAA.Remove("3");
					break;
				}
			}
		}
		else if (seat == "A4")
		{
			for (int i = 0; i < rowAA.Count; i++)
			{
				if (rowAA.Contains("4"))
				{
					rowAA.Remove("4");
					break;
				}
			}
		}
		else if (seat == "A5")
		{
			for (int i = 0; i < rowAA.Count; i++)
			{
				if (rowAA.Contains("5"))
				{
					rowAA.Remove("5");
					break;
				}
			}
		}
		else if (seat == "A6")
		{
			for (int i = 0; i < rowAA.Count; i++)
			{
				if (rowAA.Contains("6"))
				{
					rowAA.Remove("6");
					break;
				}
			}
		}
		else if (seat == "A7")
		{
			for (int i = 0; i < rowAA.Count; i++)
			{
				if (rowAA.Contains("7"))
				{
					rowAA.Remove("7");
					break;
				}
			}
		}
		else if (seat == "A8")
		{
			for (int i = 0; i < rowAA.Count; i++)
			{
				if (rowAA.Contains("8"))
				{
					rowAA.Remove("8");
					break;
				}
			}
		}
		else if (seat == "A9")
		{
			for (int i = 0; i < rowAA.Count; i++)
			{
				if (rowAA.Contains("9"))
				{
					rowAA.Remove("9");
					break;
				}
			}
		}
		else if (seat == "A10")
		{
			for (int i = 0; i < rowAA.Count; i++)
			{
				if (rowAA.Contains("10"))
				{
					rowAA.Remove("10");
					break;
				}
			}
		}
		string resultt = "[ " + string.Join(" ", rowAA) + " ]";
		Console.WriteLine(resultt);
	}

	if (seat.StartsWith("B"))
	{
		rowBB = new List<string>(rowBBB);
		if (seat == "B1")
		{
			for (int i = 0; i < rowBB.Count; i++)
			{
				if (rowBB.Contains("1"))
				{
					rowBB.Remove("1");
					break;
				}
			}
		}
		else if (seat == "B2")
		{
			for (int i = 0; i < rowBB.Count; i++)
			{
				if (rowBB.Contains("2"))
				{
					rowBB.Remove("2");
					break;
				}
			}
		}
		else if (seat == "B3")
		{
			for (int i = 0; i < rowBB.Count; i++)
			{
				if (rowBB.Contains("3"))
				{
					rowBB.Remove("3");
					break;
				}
			}
		}
		else if (seat == "B4")
		{
			for (int i = 0; i < rowBB.Count; i++)
			{
				if (rowBB.Contains("4"))
				{
					rowBB.Remove("4");
					break;
				}
			}
		}
		else if (seat == "B5")
		{
			for (int i = 0; i < rowBB.Count; i++)
			{
				if (rowBB.Contains("5"))
				{
					rowBB.Remove("5");
					break;
				}
			}
		}
		else if (seat == "B6")
		{
			for (int i = 0; i < rowBB.Count; i++)
			{
				if (rowBB.Contains("6"))
				{
					rowBB.Remove("6");
					break;
				}
			}
		}
		else if (seat == "B7")
		{
			for (int i = 0; i < rowBB.Count; i++)
			{
				if (rowBB.Contains("7"))
				{
					rowBB.Remove("7");
					break;
				}
			}
		}
		else if (seat == "B8")
		{
			for (int i = 0; i < rowBB.Count; i++)
			{
				if (rowBB.Contains("8"))
				{
					rowBB.Remove("8");
					break;
				}
			}
		}
		else if (seat == "B9")
		{
			for (int i = 0; i < rowBB.Count; i++)
			{
				if (rowBB.Contains("9"))
				{
					rowBB.Remove("9");
					break;
				}
			}
		}
		else if (seat == "B10")
		{
			for (int i = 0; i < rowBB.Count; i++)
			{
				if (rowBB.Contains("10"))
				{
					rowBB.Remove("10");
					break;
				}
			}
		}
		string resultt = "[ " + string.Join(" ", rowBB) + " ]";
		Console.WriteLine(resultt);
	}

	if (seat.StartsWith("C"))
	{
		rowCC = new List<string>(rowCCC);
		if (seat == "C1")
		{
			for (int i = 0; i < rowCC.Count; i++)
			{
				if (rowCC.Contains("1"))
				{
					rowCC.Remove("1");
					break;
				}
			}
		}
		else if (seat == "C2")
		{
			for (int i = 0; i < rowCC.Count; i++)
			{
				if (rowCC.Contains("2"))
				{
					rowCC.Remove("2");
					break;
				}
			}
		}
		else if (seat == "C3")
		{
			for (int i = 0; i < rowCC.Count; i++)
			{
				if (rowCC.Contains("3"))
				{
					rowCC.Remove("3");
					break;
				}
			}
		}
		else if (seat == "C4")
		{
			for (int i = 0; i < rowCC.Count; i++)
			{
				if (rowCC.Contains("4"))
				{
					rowCC.Remove("4");
					break;
				}
			}
		}
		else if (seat == "C5")
		{
			for (int i = 0; i < rowCC.Count; i++)
			{
				if (rowCC.Contains("5"))
				{
					rowCC.Remove("5");
					break;
				}
			}
		}
		else if (seat == "C6")
		{
			for (int i = 0; i < rowCC.Count; i++)
			{
				if (rowCC.Contains("6"))
				{
					rowCC.Remove("6");
					break;
				}
			}
		}
		else if (seat == "C7")
		{
			for (int i = 0; i < rowCC.Count; i++)
			{
				if (rowCC.Contains("7"))
				{
					rowCC.Remove("7");
					break;
				}
			}
		}
		else if (seat == "C8")
		{
			for (int i = 0; i < rowCC.Count; i++)
			{
				if (rowCC.Contains("8"))
				{
					rowCC.Remove("8");
					break;
				}
			}
		}
		else if (seat == "C9")
		{
			for (int i = 0; i < rowCC.Count; i++)
			{
				if (rowCC.Contains("9"))
				{
					rowCC.Remove("9");
					break;
				}
			}
		}
		else if (seat == "C10")
		{
			for (int i = 0; i < rowCC.Count; i++)
			{
				if (rowCC.Contains("10"))
				{
					rowCC.Remove("10");
					break;
				}
			}
		}
		string resultt = "[ " + string.Join(" ", rowCC) + " ]";
		Console.WriteLine(resultt);
	}

	if (seat.StartsWith("D"))
	{
		rowDD = new List<string>(rowDDD);
		if (seat == "D1")
		{
			for (int i = 0; i < rowDD.Count; i++)
			{
				if (rowDD.Contains("1"))
				{
					rowDD.Remove("1");
					break;
				}
			}
		}
		else if (seat == "D2")
		{
			for (int i = 0; i < rowDD.Count; i++)
			{
				if (rowDD.Contains("2"))
				{
					rowDD.Remove("2");
					break;
				}
			}
		}
		else if (seat == "D3")
		{
			for (int i = 0; i < rowDD.Count; i++)
			{
				if (rowDD.Contains("3"))
				{
					rowDD.Remove("3");
					break;
				}
			}
		}
		else if (seat == "D4")
		{
			for (int i = 0; i < rowDD.Count; i++)
			{
				if (rowDD.Contains("4"))
				{
					rowDD.Remove("4");
					break;
				}
			}
		}
		else if (seat == "D5")
		{
			for (int i = 0; i < rowDD.Count; i++)
			{
				if (rowDD.Contains("5"))
				{
					rowDD.Remove("5");
					break;
				}
			}
		}
		else if (seat == "D6")
		{
			for (int i = 0; i < rowDD.Count; i++)
			{
				if (rowDD.Contains("6"))
				{
					rowDD.Remove("6");
					break;
				}
			}
		}
		else if (seat == "D7")
		{
			for (int i = 0; i < rowDD.Count; i++)
			{
				if (rowDD.Contains("7"))
				{
					rowDD.Remove("7");
					break;
				}
			}
		}
		else if (seat == "D8")
		{
			for (int i = 0; i < rowDD.Count; i++)
			{
				if (rowDD.Contains("8"))
				{
					rowDD.Remove("8");
					break;
				}
			}
		}
		else if (seat == "D9")
		{
			for (int i = 0; i < rowDD.Count; i++)
			{
				if (rowDD.Contains("9"))
				{
					rowDD.Remove("9");
					break;
				}
			}
		}
		else if (seat == "D10")
		{
			for (int i = 0; i < rowDD.Count; i++)
			{
				if (rowDD.Contains("10"))
				{
					rowDD.Remove("10");
					break;
				}
			}
		}
		string resultt = "[ " + string.Join(" ", rowDD) + " ]";
		Console.WriteLine(resultt);
	}

	if (seat.StartsWith("E"))
	{
		rowEE = new List<string>(rowEEE);
		if (seat == "E1")
		{
			for (int i = 0; i < rowEE.Count; i++)
			{
				if (rowEE.Contains("1"))
				{
					rowEE.Remove("1");
					break;
				}
			}
		}
		else if (seat == "E2")
		{
			for (int i = 0; i < rowEE.Count; i++)
			{
				if (rowEE.Contains("2"))
				{
					rowEE.Remove("2");
					break;
				}
			}
		}
		else if (seat == "E3")
		{
			for (int i = 0; i < rowEE.Count; i++)
			{
				if (rowEE.Contains("3"))
				{
					rowEE.Remove("3");
					break;
				}
			}
		}
		else if (seat == "E4")
		{
			for (int i = 0; i < rowEE.Count; i++)
			{
				if (rowEE.Contains("4"))
				{
					rowEE.Remove("4");
					break;
				}
			}
		}
		else if (seat == "E5")
		{
			for (int i = 0; i < rowEE.Count; i++)
			{
				if (rowEE.Contains("5"))
				{
					rowEE.Remove("5");
					break;
				}
			}
		}
		else if (seat == "E6")
		{
			for (int i = 0; i < rowEE.Count; i++)
			{
				if (rowEE.Contains("6"))
				{
					rowEE.Remove("6");
					break;
				}
			}
		}
		else if (seat == "E7")
		{
			for (int i = 0; i < rowEE.Count; i++)
			{
				if (rowEE.Contains("7"))
				{
					rowEE.Remove("7");
					break;
				}
			}
		}
		else if (seat == "E8")
		{
			for (int i = 0; i < rowEE.Count; i++)
			{
				if (rowEE.Contains("8"))
				{
					rowEE.Remove("8");
					break;
				}
			}
		}
		else if (seat == "E9")
		{
			for (int i = 0; i < rowEE.Count; i++)
			{
				if (rowEE.Contains("9"))
				{
					rowEE.Remove("9");
					break;
				}
			}
		}
		else if (seat == "E10")
		{
			for (int i = 0; i < rowEE.Count; i++)
			{
				if (rowEE.Contains("10"))
				{
					rowEE.Remove("10");
					break;
				}
			}
		}
		string resultt = "[ " + string.Join(" ", rowEE) + " ]";
		Console.WriteLine(resultt);
	}
}
while (answer == "yes")
{
	Movies();
	Console.WriteLine("Do you want to book tickets for another movie? (yes/no):\n");
	answer = Console.ReadLine();

	if (answer == "no")
	{
		Console.WriteLine("Thank you for using the Movie Ticket Booking System. Have a great day!");
		break;
	}
}