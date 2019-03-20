using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;


namespace BetaTestOfTheThreading
{
	class Program
	{
		static void Main(string[] args)
		{
			Snake snake = new Snake(10, 10);
			Thread thread = new Thread(snake.Move);
			thread.Start();
			snake.ChangeOfTheDir();
		}
	}
}
