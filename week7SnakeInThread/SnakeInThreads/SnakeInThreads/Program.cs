using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeInThreads
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.CursorVisible = false;
			Console.BackgroundColor = ConsoleColor.White;
			Console.ForegroundColor = ConsoleColor.Black;
			Console.Clear();
			//	Game game = new Game(0);
			//	game.Start();
			Console.Write("Please Write your name: ");
			Menu menu = new Menu(Console.ReadLine());
			menu.Start();
			
		}
	}
}
