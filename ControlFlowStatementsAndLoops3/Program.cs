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

List<string> rowAA = new List<string>();
if (seat.StartsWith("A"))
{
	rowAA = new List<string>(rowA);
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
	if (seat == "A2")
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
	if (seat == "A3")
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
	if (seat == "A4")
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
	if (seat == "A5")
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
	if (seat == "A6")
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
	if (seat == "A7")
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
	if (seat == "A8")
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
	if (seat == "A9")
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
	if (seat == "A10")
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

if (seat.StartsWith("B"))
{
	List<string> rowBB = new List<string>(rowB);
	string resultt = "[ " + string.Join(" ", rowBB) + " ]";
	switch (seat)
	{
		case "B1":
			rowBB.RemoveAt(0);
			rowBB.ToArray();
			Console.Write("\nRow B: ");
			resultt = "[ " + string.Join(" ", rowBB) + " ]\n";
			Console.WriteLine(resultt);
			break;
		case "B2":
			rowBB.RemoveAt(1);
			rowBB.ToArray();
			Console.Write("\nRow B: ");
			resultt = "[ " + string.Join(" ", rowBB) + " ]\n";
			Console.WriteLine(resultt);
			break;
		case "B3":
			rowBB.RemoveAt(2);
			rowBB.ToArray();
			Console.Write("\nRow B: ");
			resultt = "[ " + string.Join(" ", rowBB) + " ]\n";
			Console.WriteLine(resultt);
			break;
		case "B4":
			rowBB.RemoveAt(3);
			rowBB.ToArray();
			Console.Write("\nRow B: ");
			resultt = "[ " + string.Join(" ", rowBB) + " ]\n";
			Console.WriteLine(resultt);
			break;
		case "B5":
			rowBB.RemoveAt(4);
			rowBB.ToArray();
			Console.Write("\nRow B: ");
			resultt = "[ " + string.Join(" ", rowBB) + " ]\n";
			Console.WriteLine(resultt);
			break;
		case "B6":
			rowBB.RemoveAt(5);
			rowBB.ToArray();
			Console.Write("\nRow B: ");
			resultt = "[ " + string.Join(" ", rowBB) + " ]\n";
			Console.WriteLine(resultt);
			break;
		case "B7":
			rowBB.RemoveAt(6);
			rowBB.ToArray();
			Console.Write("\nRow B: ");
			resultt = "[ " + string.Join(" ", rowBB) + " ]\n";
			Console.WriteLine(resultt);
			break;
		case "B8":
			rowBB.RemoveAt(7);
			rowBB.ToArray();
			Console.Write("\nRow B: ");
			resultt = "[ " + string.Join(" ", rowBB) + " ]\n";
			Console.WriteLine(resultt);
			break;
		case "B9":
			rowBB.RemoveAt(8);
			rowBB.ToArray();
			Console.Write("\nRow B: ");
			resultt = "[ " + string.Join(" ", rowBB) + " ]\n";
			Console.WriteLine(resultt);
			break;
		case "B10":
			rowBB.RemoveAt(9);
			rowBB.ToArray();
			Console.Write("\nRow B: ");
			resultt = "[ " + string.Join(" ", rowBB) + " ]\n";
			Console.WriteLine(resultt);
			break;
	}
}

if (seat.StartsWith("C"))
{
	List<string> rowCC = new List<string>(rowC);
	string resultt = "[ " + string.Join(" ", rowCC) + " ]";
	switch (seat)
	{
		case "C1":
			rowCC.RemoveAt(0);
			rowCC.ToArray();
			Console.Write("\nRow C: ");
			resultt = "[ " + string.Join(" ", rowCC) + " ]\n";
			Console.WriteLine(resultt);
			break;
		case "C2":
			rowCC.RemoveAt(1);
			rowCC.ToArray();
			Console.Write("\nRow C: ");
			resultt = "[ " + string.Join(" ", rowCC) + " ]\n";
			Console.WriteLine(resultt);
			break;
		case "C3":
			rowCC.RemoveAt(2);
			rowCC.ToArray();
			Console.Write("\nRow C: ");
			resultt = "[ " + string.Join(" ", rowCC) + " ]\n";
			Console.WriteLine(resultt);
			break;
		case "C4":
			rowCC.RemoveAt(3);
			rowCC.ToArray();
			Console.Write("\nRow C: ");
			resultt = "[ " + string.Join(" ", rowCC) + " ]\n";
			Console.WriteLine(resultt);
			break;
		case "C5":
			rowCC.RemoveAt(4);
			rowCC.ToArray();
			Console.Write("\nRow C: ");
			resultt = "[ " + string.Join(" ", rowCC) + " ]\n";
			Console.WriteLine(resultt);
			break;
		case "C6":
			rowCC.RemoveAt(5);
			rowCC.ToArray();
			Console.Write("\nRow C: ");
			resultt = "[ " + string.Join(" ", rowCC) + " ]\n";
			Console.WriteLine(resultt);
			break;
		case "C7":
			rowCC.RemoveAt(6);
			rowCC.ToArray();
			Console.Write("\nRow C: ");
			resultt = "[ " + string.Join(" ", rowCC) + " ]\n";
			Console.WriteLine(resultt);
			break;
		case "C8":
			rowCC.RemoveAt(7);
			rowCC.ToArray();
			Console.Write("\nRow C: ");
			resultt = "[ " + string.Join(" ", rowCC) + " ]\n";
			Console.WriteLine(resultt);
			break;
		case "C9":
			rowCC.RemoveAt(8);
			rowCC.ToArray();
			Console.Write("\nRow C: ");
			resultt = "[ " + string.Join(" ", rowCC) + " ]\n";
			Console.WriteLine(resultt);
			break;
		case "C10":
			rowCC.RemoveAt(9);
			rowCC.ToArray();
			Console.Write("\nRow C: ");
			resultt = "[ " + string.Join(" ", rowCC) + " ]\n";
			Console.WriteLine(resultt);
			break;
	}
}

if (seat.StartsWith("D"))
{
	List<string> rowDD = new List<string>(rowD);
	string resultt = "[ " + string.Join(" ", rowDD) + " ]";
	switch (seat)
	{
		case "D1":
			rowDD.RemoveAt(0);
			rowDD.ToArray();
			Console.Write("\nRow D: ");
			resultt = "[ " + string.Join(" ", rowDD) + " ]\n";
			Console.WriteLine(resultt);
			break;
		case "D2":
			rowDD.RemoveAt(1);
			rowDD.ToArray();
			Console.Write("\nRow D: ");
			resultt = "[ " + string.Join(" ", rowDD) + " ]\n";
			Console.WriteLine(resultt);
			break;
		case "D3":
			rowDD.RemoveAt(2);
			rowDD.ToArray();
			Console.Write("\nRow D: ");
			resultt = "[ " + string.Join(" ", rowDD) + " ]\n";
			Console.WriteLine(resultt);
			break;
		case "D4":
			rowDD.RemoveAt(3);
			rowDD.ToArray();
			Console.Write("\nRow D: ");
			resultt = "[ " + string.Join(" ", rowDD) + " ]\n";
			Console.WriteLine(resultt);
			break;
		case "D5":
			rowDD.RemoveAt(4);
			rowDD.ToArray();
			Console.Write("\nRow D: ");
			resultt = "[ " + string.Join(" ", rowDD) + " ]\n";
			Console.WriteLine(resultt);
			break;
		case "D6":
			rowDD.RemoveAt(5);
			rowDD.ToArray();
			Console.Write("\nRow D: ");
			resultt = "[ " + string.Join(" ", rowDD) + " ]\n";
			Console.WriteLine(resultt);
			break;
		case "D7":
			rowDD.RemoveAt(6);
			rowDD.ToArray();
			Console.Write("\nRow D: ");
			resultt = "[ " + string.Join(" ", rowDD) + " ]\n";
			Console.WriteLine(resultt);
			break;
		case "D8":
			rowDD.RemoveAt(7);
			rowDD.ToArray();
			Console.Write("\nRow D: ");
			resultt = "[ " + string.Join(" ", rowDD) + " ]\n";
			Console.WriteLine(resultt);
			break;
		case "D9":
			rowDD.RemoveAt(8);
			rowDD.ToArray();
			Console.Write("\nRow D: ");
			resultt = "[ " + string.Join(" ", rowDD) + " ]\n";
			Console.WriteLine(resultt);
			break;
		case "D10":
			rowDD.RemoveAt(9);
			rowDD.ToArray();
			Console.Write("\nRow D: ");
			resultt = "[ " + string.Join(" ", rowDD) + " ]\n";
			Console.WriteLine(resultt);
			break;
	}
}

if (seat.StartsWith("E"))
{
	List<string> rowEE = new List<string>(rowE);
	string resultt = "[ " + string.Join(" ", rowEE) + " ]";
	switch (seat)
	{
		case "E1":
			rowEE.RemoveAt(0);
			rowEE.ToArray();
			Console.Write("\nRow E: ");
			resultt = "[ " + string.Join(" ", rowEE) + " ]\n";
			Console.WriteLine(resultt);
			break;
		case "E2":
			rowEE.RemoveAt(1);
			rowEE.ToArray();
			Console.Write("\nRow E: ");
			resultt = "[ " + string.Join(" ", rowEE) + " ]\n";
			Console.WriteLine(resultt);
			break;
		case "E3":
			rowEE.RemoveAt(2);
			rowEE.ToArray();
			Console.Write("\nRow E: ");
			resultt = "[ " + string.Join(" ", rowEE) + " ]\n";
			Console.WriteLine(resultt);
			break;
		case "E4":
			rowEE.RemoveAt(3);
			rowEE.ToArray();
			Console.Write("\nRow E: ");
			resultt = "[ " + string.Join(" ", rowEE) + " ]\n";
			Console.WriteLine(resultt);
			break;
		case "E5":
			rowEE.RemoveAt(4);
			rowEE.ToArray();
			Console.Write("\nRow E: ");
			resultt = "[ " + string.Join(" ", rowEE) + " ]\n";
			Console.WriteLine(resultt);
			break;
		case "E6":
			rowEE.RemoveAt(5);
			rowEE.ToArray();
			Console.Write("\nRow E: ");
			resultt = "[ " + string.Join(" ", rowEE) + " ]\n";
			Console.WriteLine(resultt);
			break;
		case "E7":
			rowEE.RemoveAt(6);
			rowEE.ToArray();
			Console.Write("\nRow E: ");
			resultt = "[ " + string.Join(" ", rowEE) + " ]\n";
			Console.WriteLine(resultt);
			break;
		case "E8":
			rowEE.RemoveAt(7);
			rowEE.ToArray();
			Console.Write("\nRow E: ");
			resultt = "[ " + string.Join(" ", rowEE) + " ]\n";
			Console.WriteLine(resultt);
			break;
		case "E9":
			rowEE.RemoveAt(8);
			rowEE.ToArray();
			Console.Write("\nRow E: ");
			resultt = "[ " + string.Join(" ", rowEE) + " ]\n";
			Console.WriteLine(resultt);
			break;
		case "E10":
			rowEE.RemoveAt(9);
			rowEE.ToArray();
			Console.Write("\nRow E: ");
			resultt = "[ " + string.Join(" ", rowEE) + " ]\n";
			Console.WriteLine(resultt);
			break;
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

	//string[] rowA = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };
	//string[] rowB = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };
	//string[] rowC = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };
	//string[] rowD = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };
	//string[] rowE = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };

	Console.Write("\nRow A: ");
	string result = "[ " + string.Join(" ", rowAA) + " ]";
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
		if (seat == "A2")
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
		if (seat == "A3")
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
		if (seat == "A4")
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
		if (seat == "A5")
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
		if (seat == "A6")
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
		if (seat == "A7")
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
		if (seat == "A8")
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
		if (seat == "A9")
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
		if (seat == "A10")
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
		List<string> rowBB = new List<string>(rowB);
		string resultt = "[ " + string.Join(" ", rowBB) + " ]";
		switch (seat)
		{
			case "B1":
				rowBB.RemoveAt(0);
				rowBB.ToArray();
				Console.Write("\nRow B: ");
				resultt = "[ " + string.Join(" ", rowBB) + " ]\n";
				Console.WriteLine(resultt);
				break;
			case "B2":
				rowBB.RemoveAt(1);
				rowBB.ToArray();
				Console.Write("\nRow B: ");
				resultt = "[ " + string.Join(" ", rowBB) + " ]\n";
				Console.WriteLine(resultt);
				break;
			case "B3":
				rowBB.RemoveAt(2);
				rowBB.ToArray();
				Console.Write("\nRow B: ");
				resultt = "[ " + string.Join(" ", rowBB) + " ]\n";
				Console.WriteLine(resultt);
				break;
			case "B4":
				rowBB.RemoveAt(3);
				rowBB.ToArray();
				Console.Write("\nRow B: ");
				resultt = "[ " + string.Join(" ", rowBB) + " ]\n";
				Console.WriteLine(resultt);
				break;
			case "B5":
				rowBB.RemoveAt(4);
				rowBB.ToArray();
				Console.Write("\nRow B: ");
				resultt = "[ " + string.Join(" ", rowBB) + " ]\n";
				Console.WriteLine(resultt);
				break;
			case "B6":
				rowBB.RemoveAt(5);
				rowBB.ToArray();
				Console.Write("\nRow B: ");
				resultt = "[ " + string.Join(" ", rowBB) + " ]\n";
				Console.WriteLine(resultt);
				break;
			case "B7":
				rowBB.RemoveAt(6);
				rowBB.ToArray();
				Console.Write("\nRow B: ");
				resultt = "[ " + string.Join(" ", rowBB) + " ]\n";
				Console.WriteLine(resultt);
				break;
			case "B8":
				rowBB.RemoveAt(7);
				rowBB.ToArray();
				Console.Write("\nRow B: ");
				resultt = "[ " + string.Join(" ", rowBB) + " ]\n";
				Console.WriteLine(resultt);
				break;
			case "B9":
				rowBB.RemoveAt(8);
				rowBB.ToArray();
				Console.Write("\nRow B: ");
				resultt = "[ " + string.Join(" ", rowBB) + " ]\n";
				Console.WriteLine(resultt);
				break;
			case "B10":
				rowBB.RemoveAt(9);
				rowBB.ToArray();
				Console.Write("\nRow B: ");
				resultt = "[ " + string.Join(" ", rowBB) + " ]\n";
				Console.WriteLine(resultt);
				break;
		}
	}

	if (seat.StartsWith("C"))
	{
		List<string> rowCC = new List<string>(rowC);
		string resultt = "[ " + string.Join(" ", rowCC) + " ]";
		switch (seat)
		{
			case "C1":
				rowCC.RemoveAt(0);
				rowCC.ToArray();
				Console.Write("\nRow C: ");
				resultt = "[ " + string.Join(" ", rowCC) + " ]\n";
				Console.WriteLine(resultt);
				break;
			case "C2":
				rowCC.RemoveAt(1);
				rowCC.ToArray();
				Console.Write("\nRow C: ");
				resultt = "[ " + string.Join(" ", rowCC) + " ]\n";
				Console.WriteLine(resultt);
				break;
			case "C3":
				rowCC.RemoveAt(2);
				rowCC.ToArray();
				Console.Write("\nRow C: ");
				resultt = "[ " + string.Join(" ", rowCC) + " ]\n";
				Console.WriteLine(resultt);
				break;
			case "C4":
				rowCC.RemoveAt(3);
				rowCC.ToArray();
				Console.Write("\nRow C: ");
				resultt = "[ " + string.Join(" ", rowCC) + " ]\n";
				Console.WriteLine(resultt);
				break;
			case "C5":
				rowCC.RemoveAt(4);
				rowCC.ToArray();
				Console.Write("\nRow C: ");
				resultt = "[ " + string.Join(" ", rowCC) + " ]\n";
				Console.WriteLine(resultt);
				break;
			case "C6":
				rowCC.RemoveAt(5);
				rowCC.ToArray();
				Console.Write("\nRow C: ");
				resultt = "[ " + string.Join(" ", rowCC) + " ]\n";
				Console.WriteLine(resultt);
				break;
			case "C7":
				rowCC.RemoveAt(6);
				rowCC.ToArray();
				Console.Write("\nRow C: ");
				resultt = "[ " + string.Join(" ", rowCC) + " ]\n";
				Console.WriteLine(resultt);
				break;
			case "C8":
				rowCC.RemoveAt(7);
				rowCC.ToArray();
				Console.Write("\nRow C: ");
				resultt = "[ " + string.Join(" ", rowCC) + " ]\n";
				Console.WriteLine(resultt);
				break;
			case "C9":
				rowCC.RemoveAt(8);
				rowCC.ToArray();
				Console.Write("\nRow C: ");
				resultt = "[ " + string.Join(" ", rowCC) + " ]\n";
				Console.WriteLine(resultt);
				break;
			case "C10":
				rowCC.RemoveAt(9);
				rowCC.ToArray();
				Console.Write("\nRow C: ");
				resultt = "[ " + string.Join(" ", rowCC) + " ]\n";
				Console.WriteLine(resultt);
				break;
		}
	}

	if (seat.StartsWith("D"))
	{
		List<string> rowDD = new List<string>(rowD);
		string resultt = "[ " + string.Join(" ", rowDD) + " ]";
		switch (seat)
		{
			case "D1":
				rowDD.RemoveAt(0);
				rowDD.ToArray();
				Console.Write("\nRow D: ");
				resultt = "[ " + string.Join(" ", rowDD) + " ]\n";
				Console.WriteLine(resultt);
				break;
			case "D2":
				rowDD.RemoveAt(1);
				rowDD.ToArray();
				Console.Write("\nRow D: ");
				resultt = "[ " + string.Join(" ", rowDD) + " ]\n";
				Console.WriteLine(resultt);
				break;
			case "D3":
				rowDD.RemoveAt(2);
				rowDD.ToArray();
				Console.Write("\nRow D: ");
				resultt = "[ " + string.Join(" ", rowDD) + " ]\n";
				Console.WriteLine(resultt);
				break;
			case "D4":
				rowDD.RemoveAt(3);
				rowDD.ToArray();
				Console.Write("\nRow D: ");
				resultt = "[ " + string.Join(" ", rowDD) + " ]\n";
				Console.WriteLine(resultt);
				break;
			case "D5":
				rowDD.RemoveAt(4);
				rowDD.ToArray();
				Console.Write("\nRow D: ");
				resultt = "[ " + string.Join(" ", rowDD) + " ]\n";
				Console.WriteLine(resultt);
				break;
			case "D6":
				rowDD.RemoveAt(5);
				rowDD.ToArray();
				Console.Write("\nRow D: ");
				resultt = "[ " + string.Join(" ", rowDD) + " ]\n";
				Console.WriteLine(resultt);
				break;
			case "D7":
				rowDD.RemoveAt(6);
				rowDD.ToArray();
				Console.Write("\nRow D: ");
				resultt = "[ " + string.Join(" ", rowDD) + " ]\n";
				Console.WriteLine(resultt);
				break;
			case "D8":
				rowDD.RemoveAt(7);
				rowDD.ToArray();
				Console.Write("\nRow D: ");
				resultt = "[ " + string.Join(" ", rowDD) + " ]\n";
				Console.WriteLine(resultt);
				break;
			case "D9":
				rowDD.RemoveAt(8);
				rowDD.ToArray();
				Console.Write("\nRow D: ");
				resultt = "[ " + string.Join(" ", rowDD) + " ]\n";
				Console.WriteLine(resultt);
				break;
			case "D10":
				rowDD.RemoveAt(9);
				rowDD.ToArray();
				Console.Write("\nRow D: ");
				resultt = "[ " + string.Join(" ", rowDD) + " ]\n";
				Console.WriteLine(resultt);
				break;
		}
	}

	if (seat.StartsWith("E"))
	{
		List<string> rowEE = new List<string>(rowE);
		string resultt = "[ " + string.Join(" ", rowEE) + " ]";
		switch (seat)
		{
			case "E1":
				rowEE.RemoveAt(0);
				rowEE.ToArray();
				Console.Write("\nRow E: ");
				resultt = "[ " + string.Join(" ", rowEE) + " ]\n";
				Console.WriteLine(resultt);
				break;
			case "E2":
				rowEE.RemoveAt(1);
				rowEE.ToArray();
				Console.Write("\nRow E: ");
				resultt = "[ " + string.Join(" ", rowEE) + " ]\n";
				Console.WriteLine(resultt);
				break;
			case "E3":
				rowEE.RemoveAt(2);
				rowEE.ToArray();
				Console.Write("\nRow E: ");
				resultt = "[ " + string.Join(" ", rowEE) + " ]\n";
				Console.WriteLine(resultt);
				break;
			case "E4":
				rowEE.RemoveAt(3);
				rowEE.ToArray();
				Console.Write("\nRow E: ");
				resultt = "[ " + string.Join(" ", rowEE) + " ]\n";
				Console.WriteLine(resultt);
				break;
			case "E5":
				rowEE.RemoveAt(4);
				rowEE.ToArray();
				Console.Write("\nRow E: ");
				resultt = "[ " + string.Join(" ", rowEE) + " ]\n";
				Console.WriteLine(resultt);
				break;
			case "E6":
				rowEE.RemoveAt(5);
				rowEE.ToArray();
				Console.Write("\nRow E: ");
				resultt = "[ " + string.Join(" ", rowEE) + " ]\n";
				Console.WriteLine(resultt);
				break;
			case "E7":
				rowEE.RemoveAt(6);
				rowEE.ToArray();
				Console.Write("\nRow E: ");
				resultt = "[ " + string.Join(" ", rowEE) + " ]\n";
				Console.WriteLine(resultt);
				break;
			case "E8":
				rowEE.RemoveAt(7);
				rowEE.ToArray();
				Console.Write("\nRow E: ");
				resultt = "[ " + string.Join(" ", rowEE) + " ]\n";
				Console.WriteLine(resultt);
				break;
			case "E9":
				rowEE.RemoveAt(8);
				rowEE.ToArray();
				Console.Write("\nRow E: ");
				resultt = "[ " + string.Join(" ", rowEE) + " ]\n";
				Console.WriteLine(resultt);
				break;
			case "E10":
				rowEE.RemoveAt(9);
				rowEE.ToArray();
				Console.Write("\nRow E: ");
				resultt = "[ " + string.Join(" ", rowEE) + " ]\n";
				Console.WriteLine(resultt);
				break;
		}
	}
}
while (answer == "yes")
{
	Movies();
	Console.WriteLine("Do you want to book tickets for another movie? (yes/no):");
	answer = Console.ReadLine();

	if (answer == "no")
	{
		Console.WriteLine("Thank you for using the Movie Ticket Booking System. Have a great day!");
		break;
	}
}