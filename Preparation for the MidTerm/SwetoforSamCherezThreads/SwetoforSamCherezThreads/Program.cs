using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
namespace SwetoforSamCherezThreads
{
	class Program
	{
		static void Main(string[] args)
		{
			Thread thread = new Thread(SHow);
			Thread[] th = new Thread[10];
			for(int k = 0; k < 10; k++)
			{
				th[k] = new Thread(SHow);
				th[k].Name = k.ToString();
				th[k].Start();
			}
			thread.Start();
			for (int k = 0; k < 999; k++)
			{
				Console.ForegroundColor = ConsoleColor.Blue;
				Console.Write(20);
			}
			Console.ReadKey();
		}
		static void SHow()
		{
			for(int k = 0; k < 999; k++)
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.Write(10 );
			}
		}
	}
}
