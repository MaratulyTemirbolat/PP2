using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task33
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.CursorVisible = false;
			Snake snake = new Snake(10, 10, '*', ConsoleColor.Yellow);
			Thread thread = new Thread(snake.ChangeDirection);
			thread.Start();
			while (true)
			{
				snake.Move();
			}
		}
	}
}
