using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
	public class Game
	{
		public bool ok ;
		public List<GameObjects> g_objects;
		public Snake snake;
		public Game()
		{
			ok = true;
			snake = new Snake(10, 10, (char)2, ConsoleColor.Red);
			g_objects = new List<GameObjects>();
			g_objects.Add(snake);
			
		}
		public void Start()
		{
			
			ConsoleKeyInfo KeyInfo=Console.ReadKey();
			
			while (ok == true && KeyInfo.Key != ConsoleKey.Escape)
			{
			
			}
		}
	}
}
