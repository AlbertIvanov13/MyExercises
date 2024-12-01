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

Console.Write("You selected: ");

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

Console.WriteLine("Available seating: ");

string[] rowA = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };
string[] rowB = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };
string[] rowC = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };
string[] rowD = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };
string[] rowE = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };

Console.Write("Row A: ");
string result = "[ " + string.Join(" ", rowA) + " ]";
Console.WriteLine(result);
Console.Write("Row B: ");
string result2 = "[ " + string.Join(" ", rowB) + " ]";
Console.WriteLine(result2);
Console.Write("Row C: ");
string result3 = "[ " + string.Join(" ", rowC) + " ]";
Console.WriteLine(result3); 
Console.Write("Row D: ");
string result4 = "[ " + string.Join(" ", rowD) + " ]";
Console.WriteLine(result4); 
Console.Write("Row E: ");
string result5 = "[ " + string.Join(" ", rowE) + " ]";
Console.WriteLine(result5);

Console.WriteLine("Please select a seat (Enter row letter and seat number, e.g., A5): ");
string seat = Console.ReadLine();

if (seat.StartsWith("A"))
{
	List<string> rowAA = new List<string>(rowA);
	string resultt = "[ " + string.Join(" ", rowAA) + " ]";
	switch (seat)
	{
		case "A1":
			rowAA.RemoveAt(0);
			rowAA.ToArray();
			Console.Write("Row A: ");
			resultt = "[ " + string.Join(" ", rowAA) + " ]";
			Console.WriteLine(resultt);
			break;
		case "A2":
			rowAA.RemoveAt(1);
			rowAA.ToArray();
			Console.Write("Row A: ");
			resultt = "[ " + string.Join(" ", rowAA) + " ]";
			Console.WriteLine(resultt);
			break;
		case "A3":
			rowAA.RemoveAt(2);
			rowAA.ToArray();
			Console.Write("Row A: ");
			resultt = "[ " + string.Join(" ", rowAA) + " ]";
			Console.WriteLine(resultt);
			break;
		case "A4":
			rowAA.RemoveAt(3);
			rowAA.ToArray();
			Console.Write("Row A: ");
			resultt = "[ " + string.Join(" ", rowAA) + " ]";
			Console.WriteLine(resultt);
			break;
		case "A5":
			rowAA.RemoveAt(4);
			rowAA.ToArray();
			Console.Write("Row A: ");
			resultt = "[ " + string.Join(" ", rowAA) + " ]";
			Console.WriteLine(resultt);
			break;
		case "A6":
			rowAA.RemoveAt(5);
			rowAA.ToArray();
			Console.Write("Row A: ");
			resultt = "[ " + string.Join(" ", rowAA) + " ]";
			Console.WriteLine(resultt);
			break;
		case "A7":
			rowAA.RemoveAt(6);
			rowAA.ToArray();
			Console.Write("Row A: ");
			resultt = "[ " + string.Join(" ", rowAA) + " ]";
			Console.WriteLine(resultt);
			break;
		case "A8":
			rowAA.RemoveAt(7);
			rowAA.ToArray();
			Console.Write("Row A: ");
			resultt = "[ " + string.Join(" ", rowAA) + " ]";
			Console.WriteLine(resultt);
			break;
		case "A9":
			rowAA.RemoveAt(8);
			rowAA.ToArray();
			Console.Write("Row A: ");
			resultt = "[ " + string.Join(" ", rowAA) + " ]";
			Console.WriteLine(resultt);
			break;
		case "A10":
			rowAA.RemoveAt(9);
			rowAA.ToArray();
			Console.Write("Row A: ");
			resultt = "[ " + string.Join(" ", rowAA) + " ]";
			Console.WriteLine(resultt);
			break;
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
			Console.Write("Row B: ");
			resultt = "[ " + string.Join(" ", rowBB) + " ]";
			Console.WriteLine(resultt);
			break;
		case "B2":
			rowBB.RemoveAt(1);
			rowBB.ToArray();
			Console.Write("Row B: ");
			resultt = "[ " + string.Join(" ", rowBB) + " ]";
			Console.WriteLine(resultt);
			break;
		case "B3":
			rowBB.RemoveAt(2);
			rowBB.ToArray();
			Console.Write("Row B: ");
			resultt = "[ " + string.Join(" ", rowBB) + " ]";
			Console.WriteLine(resultt);
			break;
		case "B4":
			rowBB.RemoveAt(3);
			rowBB.ToArray();
			Console.Write("Row B: ");
			resultt = "[ " + string.Join(" ", rowBB) + " ]";
			Console.WriteLine(resultt);
			break;
		case "B5":
			rowBB.RemoveAt(4);
			rowBB.ToArray();
			Console.Write("Row B: ");
			resultt = "[ " + string.Join(" ", rowBB) + " ]";
			Console.WriteLine(resultt);
			break;
		case "B6":
			rowBB.RemoveAt(5);
			rowBB.ToArray();
			Console.Write("Row B: ");
			resultt = "[ " + string.Join(" ", rowBB) + " ]";
			Console.WriteLine(resultt);
			break;
		case "B7":
			rowBB.RemoveAt(6);
			rowBB.ToArray();
			Console.Write("Row B: ");
			resultt = "[ " + string.Join(" ", rowBB) + " ]";
			Console.WriteLine(resultt);
			break;
		case "B8":
			rowBB.RemoveAt(7);
			rowBB.ToArray();
			Console.Write("Row B: ");
			resultt = "[ " + string.Join(" ", rowBB) + " ]";
			Console.WriteLine(resultt);
			break;
		case "B9":
			rowBB.RemoveAt(8);
			rowBB.ToArray();
			Console.Write("Row B: ");
			resultt = "[ " + string.Join(" ", rowBB) + " ]";
			Console.WriteLine(resultt);
			break;
		case "B10":
			rowBB.RemoveAt(9);
			rowBB.ToArray();
			Console.Write("Row B: ");
			resultt = "[ " + string.Join(" ", rowBB) + " ]";
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
			Console.Write("Row C: ");
			resultt = "[ " + string.Join(" ", rowCC) + " ]";
			Console.WriteLine(resultt);
			break;
		case "C2":
			rowCC.RemoveAt(1);
			rowCC.ToArray();
			Console.Write("Row C: ");
			resultt = "[ " + string.Join(" ", rowCC) + " ]";
			Console.WriteLine(resultt);
			break;
		case "C3":
			rowCC.RemoveAt(2);
			rowCC.ToArray();
			Console.Write("Row C: ");
			resultt = "[ " + string.Join(" ", rowCC) + " ]";
			Console.WriteLine(resultt);
			break;
		case "C4":
			rowCC.RemoveAt(3);
			rowCC.ToArray();
			Console.Write("Row C: ");
			resultt = "[ " + string.Join(" ", rowCC) + " ]";
			Console.WriteLine(resultt);
			break;
		case "C5":
			rowCC.RemoveAt(4);
			rowCC.ToArray();
			Console.Write("Row C: ");
			resultt = "[ " + string.Join(" ", rowCC) + " ]";
			Console.WriteLine(resultt);
			break;
		case "C6":
			rowCC.RemoveAt(5);
			rowCC.ToArray();
			Console.Write("Row C: ");
			resultt = "[ " + string.Join(" ", rowCC) + " ]";
			Console.WriteLine(resultt);
			break;
		case "C7":
			rowCC.RemoveAt(6);
			rowCC.ToArray();
			Console.Write("Row C: ");
			resultt = "[ " + string.Join(" ", rowCC) + " ]";
			Console.WriteLine(resultt);
			break;
		case "C8":
			rowCC.RemoveAt(7);
			rowCC.ToArray();
			Console.Write("Row C: ");
			resultt = "[ " + string.Join(" ", rowCC) + " ]";
			Console.WriteLine(resultt);
			break;
		case "C9":
			rowCC.RemoveAt(8);
			rowCC.ToArray();
			Console.Write("Row C: ");
			resultt = "[ " + string.Join(" ", rowCC) + " ]";
			Console.WriteLine(resultt);
			break;
		case "C10":
			rowCC.RemoveAt(9);
			rowCC.ToArray();
			Console.Write("Row C: ");
			resultt = "[ " + string.Join(" ", rowCC) + " ]";
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
			Console.Write("Row D: ");
			resultt = "[ " + string.Join(" ", rowDD) + " ]";
			Console.WriteLine(resultt);
			break;
		case "D2":
			rowDD.RemoveAt(1);
			rowDD.ToArray();
			Console.Write("Row D: ");
			resultt = "[ " + string.Join(" ", rowDD) + " ]";
			Console.WriteLine(resultt);
			break;
		case "D3":
			rowDD.RemoveAt(2);
			rowDD.ToArray();
			Console.Write("Row D: ");
			resultt = "[ " + string.Join(" ", rowDD) + " ]";
			Console.WriteLine(resultt);
			break;
		case "D4":
			rowDD.RemoveAt(3);
			rowDD.ToArray();
			Console.Write("Row D: ");
			resultt = "[ " + string.Join(" ", rowDD) + " ]";
			Console.WriteLine(resultt);
			break;
		case "D5":
			rowDD.RemoveAt(4);
			rowDD.ToArray();
			Console.Write("Row D: ");
			resultt = "[ " + string.Join(" ", rowDD) + " ]";
			Console.WriteLine(resultt);
			break;
		case "D6":
			rowDD.RemoveAt(5);
			rowDD.ToArray();
			Console.Write("Row D: ");
			resultt = "[ " + string.Join(" ", rowDD) + " ]";
			Console.WriteLine(resultt);
			break;
		case "D7":
			rowDD.RemoveAt(6);
			rowDD.ToArray();
			Console.Write("Row D: ");
			resultt = "[ " + string.Join(" ", rowDD) + " ]";
			Console.WriteLine(resultt);
			break;
		case "D8":
			rowDD.RemoveAt(7);
			rowDD.ToArray();
			Console.Write("Row D: ");
			resultt = "[ " + string.Join(" ", rowDD) + " ]";
			Console.WriteLine(resultt);
			break;
		case "D9":
			rowDD.RemoveAt(8);
			rowDD.ToArray();
			Console.Write("Row D: ");
			resultt = "[ " + string.Join(" ", rowDD) + " ]";
			Console.WriteLine(resultt);
			break;
		case "D10":
			rowDD.RemoveAt(9);
			rowDD.ToArray();
			Console.Write("Row D: ");
			resultt = "[ " + string.Join(" ", rowDD) + " ]";
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
			Console.Write("Row E: ");
			resultt = "[ " + string.Join(" ", rowEE) + " ]";
			Console.WriteLine(resultt);
			break;
		case "E2":
			rowEE.RemoveAt(1);
			rowEE.ToArray();
			Console.Write("Row E: ");
			resultt = "[ " + string.Join(" ", rowEE) + " ]";
			Console.WriteLine(resultt);
			break;
		case "E3":
			rowEE.RemoveAt(2);
			rowEE.ToArray();
			Console.Write("Row E: ");
			resultt = "[ " + string.Join(" ", rowEE) + " ]";
			Console.WriteLine(resultt);
			break;
		case "E4":
			rowEE.RemoveAt(3);
			rowEE.ToArray();
			Console.Write("Row E: ");
			resultt = "[ " + string.Join(" ", rowEE) + " ]";
			Console.WriteLine(resultt);
			break;
		case "E5":
			rowEE.RemoveAt(4);
			rowEE.ToArray();
			Console.Write("Row E: ");
			resultt = "[ " + string.Join(" ", rowEE) + " ]";
			Console.WriteLine(resultt);
			break;
		case "E6":
			rowEE.RemoveAt(5);
			rowEE.ToArray();
			Console.Write("Row E: ");
			resultt = "[ " + string.Join(" ", rowEE) + " ]";
			Console.WriteLine(resultt);
			break;
		case "E7":
			rowEE.RemoveAt(6);
			rowEE.ToArray();
			Console.Write("Row E: ");
			resultt = "[ " + string.Join(" ", rowEE) + " ]";
			Console.WriteLine(resultt);
			break;
		case "E8":
			rowEE.RemoveAt(7);
			rowEE.ToArray();
			Console.Write("Row E: ");
			resultt = "[ " + string.Join(" ", rowEE) + " ]";
			Console.WriteLine(resultt);
			break;
		case "E9":
			rowEE.RemoveAt(8);
			rowEE.ToArray();
			Console.Write("Row E: ");
			resultt = "[ " + string.Join(" ", rowEE) + " ]";
			Console.WriteLine(resultt);
			break;
		case "E10":
			rowEE.RemoveAt(9);
			rowEE.ToArray();
			Console.Write("Row E: ");
			resultt = "[ " + string.Join(" ", rowEE) + " ]";
			Console.WriteLine(resultt);
			break;
	}
}