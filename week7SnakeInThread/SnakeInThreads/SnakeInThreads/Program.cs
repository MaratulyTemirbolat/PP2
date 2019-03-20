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
		//	Console.Clear();
		//	Game game = new Game(0);
		//	game.Start();
			Menu menu = new Menu();
			menu.Start();
			
		}
	}
}
