using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;

namespace ExercisesOnThreads
{
	class Program
	{
		public static List<Points> Body1 = new List<Points>();
		public static List<Points> Body2 = new List<Points>();
		public static List<Points> Body3 = new List<Points>();
		static int cnt = 1;
		static void Main(string[] args)
		{
			Console.CursorVisible = false;
			Thread t1 = new Thread(Red);
			Thread t2 = new Thread(Yellow);
			Thread t3 = new Thread(Green);
			StreamReader sr1 = new StreamReader("Red.txt");
			string[] Str1 = sr1.ReadToEnd().Split('\n');
			for (int k = 0; k < Str1.Length; k++)
			{
				for (int j = 0; j < Str1[k].Length; j++)
				{
					if (Str1[k][j] == '*')
						Body1.Add(new Points(j, k));
				}
			}
			sr1.Close();
			StreamReader sr2 = new StreamReader("Yellow.txt");
			string[] Str2 = sr2.ReadToEnd().Split('\n');
			for(int k = 0; k < Str2.Length; k++)
			{
				for(int j = 0; j < Str2[k].Length; j++)
				{
					if (Str2[k][j] == '*')
						Body2.Add(new Points(j, k));
				}
			}
			sr2.Close();
			StreamReader sr3 = new StreamReader("Green.txt");
			string[] Str3 = sr3.ReadToEnd().Split('\n');
			for (int k = 0; k < Str3.Length; k++)
			{
				for (int j = 0; j < Str3[k].Length; j++)
				{
					if (Str3[k][j] == '*')
						Body3.Add(new Points(j, k));
				}
			}
			t1.Start();
			t2.Start();
			t3.Start();
			
		}
		public static void Red()
		{
			while (true)
			{
				if (cnt == 1)
				{
					foreach (Points p in Body1)
					{
						Console.SetCursorPosition(p.x, p.y);
						Console.ForegroundColor = ConsoleColor.Red;
						Console.Write('*');
					}
					Thread.Sleep(3000);
					cnt++;
				}
				foreach (Points p in Body1)
				{
					Console.SetCursorPosition(p.x, p.y);
					Console.ForegroundColor = ConsoleColor.White;
					Console.Write('*');
				}
				Thread.Sleep(3000);
			}
		}
		public static void Yellow()
		{
			while (true)
			{
				if (cnt == 2)
				{
					foreach (Points p in Body2)
					{
						Console.SetCursorPosition(p.x, p.y);
						Console.ForegroundColor = ConsoleColor.Yellow;
						Console.Write('*');
					}
					Thread.Sleep(3000);
					cnt++;
				}
				foreach (Points p in Body2)
				{
					Console.SetCursorPosition(p.x, p.y);
					Console.ForegroundColor = ConsoleColor.White;
					Console.Write('*');
				}
				Thread.Sleep(3000);
			}
		}
		public static void Green()
		{
			while (true)
			{
				if (cnt == 3)
				{
					foreach (Points p in Body3)
					{
						Console.SetCursorPosition(p.x, p.y);
						Console.ForegroundColor = ConsoleColor.Green;
						Console.Write('*');
					}
					Thread.Sleep(3000);
					cnt = 1;
				}
				foreach (Points p in Body3)
				{
					Console.SetCursorPosition(p.x, p.y);
					Console.ForegroundColor = ConsoleColor.White;
					Console.Write('*');
				}
				Thread.Sleep(3000);
			}
		}
		
	}
}
