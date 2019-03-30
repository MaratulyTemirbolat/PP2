using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace SvetoforNew
{
	class Program
	{
		static void Main(string[] args)
		{
			while (true)
			{
				Draw(ConsoleColor.Red, ConsoleColor.White, ConsoleColor.White);
				Thread.Sleep(1000);
				Draw(ConsoleColor.White, ConsoleColor.Yellow, ConsoleColor.White);
				Thread.Sleep(1000);
				Draw(ConsoleColor.White, ConsoleColor.White, ConsoleColor.Green);
				Thread.Sleep(1000);
			}
		}
		static void Draw(ConsoleColor color1 ,ConsoleColor color2,ConsoleColor color3)
		{
			for(int k = 0; k < 10; k++)
			{
				for(int j = 0; j < 20; j++)
				{
					Console.SetCursorPosition(j, k);
					Console.ForegroundColor = color1;
					Console.Write('#');
				}
			}
			Console.WriteLine();
			for(int k = 10; k < 20; k++)
			{
				for(int j = 0; j < 20; j++)
				{
					Console.SetCursorPosition(j, k+1);
					Console.ForegroundColor = color2;
					Console.Write('$');
				}
			}
			
			for(int k=20; k < 30; k++)
			{
				for(int j = 0; j < 20; j++)
				{
					Console.SetCursorPosition(j, k+2);
					Console.ForegroundColor = color3;
					Console.Write('&');
				}
			}
			
		}
	}
}
