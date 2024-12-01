using System.Globalization;
using System.Transactions;

DateTime input = DateTime.Parse(Console.ReadLine());

DateTime currentDate = DateTime.Now;

TimeSpan timeSpan = currentDate - input;

double totalDays = timeSpan.TotalDays;
double years = totalDays / 365.25;

double months = Math.Abs(DateTime.Now.Month - input.Month);

double daysInMonth = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);

if (input.Day < DateTime.Now.Day)
{
	double difference = DateTime.Now.Day - input.Day;
	Console.WriteLine($"{(int)years} years, {(int)months} months and {(int)difference} days");
}
else if (input.Day > DateTime.Now.Day)
{
	if (daysInMonth == 31)
	{
		months -= 1;
		double previousMonthDays = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month - 1);
		double difference = (31 - input.Day) + DateTime.Now.Day + 1;
		Console.WriteLine($"{(int)years} years, {(int)months} months and {(int)difference} days");
	}
	else if (daysInMonth == 30)
	{
		months -= 1;
		double previousMonthDays = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month - 1);
		double difference = (30 - input.Day) + DateTime.Now.Day + 1;
		Console.WriteLine($"{(int)years} years, {(int)months} months and {(int)difference} days");
	}
	else if (daysInMonth == 29)
	{
		months -= 1;
		double previousMonthDays = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month - 1);
		double difference = (29 - input.Day) + DateTime.Now.Day + 1;
		Console.WriteLine($"{(int)years} years, {(int)months} months and {(int)difference} days");
	}
	else if (daysInMonth == 28)
	{
		months -= 1;
		double previousMonthDays = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month - 1);
		double difference = (28 - input.Day) + DateTime.Now.Day + 1;
		Console.WriteLine($"{(int)years} years, {(int)months} months and {(int)difference} days");
	}
}

int currentYear = DateTime.Now.Year;
int nextYear = currentYear += 1;
DateTime newDate = new DateTime(nextYear, input.Month, input.Day);
int nextYearBirthday = Math.Abs(DateTime.Now.DayOfYear - newDate.DayOfYear);
bool isLeap = DateTime.IsLeapYear(nextYear);

if (isLeap)
{
	Console.WriteLine($"{365 - nextYearBirthday} days until the next birthday");
}
else
{
	Console.WriteLine($"{366 - nextYearBirthday} days until the next birthday");
}

if ((int)years % 10 == 0)
{
	Console.WriteLine("You are in yubilei");
}
else
{
	Console.WriteLine("You are not in yubilei");
}

Console.WriteLine("Following yubileis: ");
for (int i = (int)Math.Floor((double)(int)years / 10) * 10; i < (int)Math.Floor(((double)(int)years / 10) * 10 + 30); i += 10)
{
	int lastTwoDigits = input.Year % 100;
	int firstTwoDigits = input.Year / 100;
	int roundedValue = (int)Math.Round((double)i / 10) * 10;
	if (roundedValue > (int)years)
	{
		int yearss = i + input.Year;
		int roundedYear = (input.Year / 10) * 10;
		Console.WriteLine($"{roundedValue} years: {input.Day}/{input.Month}/{yearss}");
	}
}