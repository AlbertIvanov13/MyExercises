using System;
using System.Threading;

namespace TicTacToe1
{
	internal class Program
	{
		static char[] spaces = new char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
		static int player = 1;
		static int choice;
		static int flag;

		static void DrawBoard()
		{
            Console.WriteLine("			|		|		");
            Console.WriteLine("		{0}	|	{1}	|	{2}	", spaces[0], spaces[1], spaces[2]);
            Console.WriteLine("_________|_______|_______");
            Console.WriteLine("			|		|		");
            Console.WriteLine("		{0}	|	{1}	|	{2}	", spaces[3], spaces[4], spaces[5]);
            Console.WriteLine("_________|_______|_______");
            Console.WriteLine("			|		|		");
            Console.WriteLine("		{0}	|	{1}	|	{2}	", spaces[6], spaces[7], spaces[8]);
            Console.WriteLine("			|		|		");
			
		}

		//static int CheckWin()
		//{
		//	if (spaces[0] == spaces[1] &&
		//		spaces[1] == spaces[2] ||
		//		spaces[3] == spaces[4] &&
		//		spaces[4] == spaces[5] ||
		//		spaces[6] == spaces[7] &&
		//		spaces[7] == spaces[8] ||
		//		spaces[0] == spaces[3] &&
		//		spaces[3] == spaces[6] ||
		//		spaces[1] == spaces[4] &&
		//		spaces[4] == spaces[7] ||
		//		spaces[2] == spaces[5] &&
		//		spaces[5] == spaces[8] ||
		//		) {
		//}

		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
		}
	}
}
