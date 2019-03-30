using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace bonusExercises
{
	class Program
	{
		static int x1 = 1, x2 = 10, y1 = 0, y2 = 0;
		static void Main(string[] args)
		{
			Console.CursorVisible = false;
			Thread t1 = new Thread(ShowABC);
			Thread t2 = new Thread(ShowDEF);
			t1.Start();
			t2.Start();
			
		}
		
		static void ShowABC()
		{
			while (true)
			{
				Console.SetCursorPosition(x1, y1);
				Console.Write("ABC"+'\n');
				y1++;
				Thread.Sleep(1000);
			}
		}
		static void ShowDEF()
		{
			while (true) {
				Console.SetCursorPosition(x2, y2);
				Console.Write("DEF"+'\n');
				y2++;
				Thread.Sleep(2000);
			}
		}
	}
}
