using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task1Again
{
	class Program
	{
		static void Main(string[] args)
		{
			
			Console.BackgroundColor = ConsoleColor.White;
			Console.Clear();
			Console.CursorVisible = false;
			Game game = new Game(0);
			game.StartTheGame();
		}
	}
}
