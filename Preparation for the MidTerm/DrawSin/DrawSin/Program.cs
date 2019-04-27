using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace DrawSin
{
	class Program
	{
		static int  x=0;
		static int y = 25;
		static bool IsTop = false;
		static bool IsDown= false;
		static void Main(string[] args)
		{
			while(true)
			DrawSin();
		}
		static void DrawSin()
		{
			if (y==5)
			{
				
				IsTop = true;
			}
			if (y == 50)
			{
				IsTop = false;
			}
			if (IsTop == true)
			{
				y += 1;
			}
			if (IsTop == false)
			{
				y -= 1;
			}
			Console.SetCursorPosition(x, y);
			Console.Write("#");
			x++;

			
			Thread.Sleep(500);
		}
	}
}
