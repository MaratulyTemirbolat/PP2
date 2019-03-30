using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;

namespace Svetofor
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = 1;
			while (true)
			{
				Console.Clear();
				Shvet();
				if (n > 3)
				{
					n = 1;
				}
				Light(n);
				Thread.Sleep(1000);
				n++;
			}
		}
		static void Shvet()
		{
			Console.ForegroundColor = ConsoleColor.White;
			int r = 0;
			StreamReader sr = new StreamReader("SVet.txt");
			while (!sr.EndOfStream)
			{
				string line = sr.ReadLine();
				for(int k = 0; k < line.Length; k++)
				{
					if (line[k] == '*')
					{
						Console.SetCursorPosition(k, r);
						Console.Write(line[k]);
						Console.CursorVisible = false;
					}
				}
				r++;
			}
		}
		static void Light(int n)
		{
			
			string name = string.Format("{0}.txt", n);
			using (StreamReader sr = new StreamReader(name))
			{
				int r = 0;
				while (!sr.EndOfStream)
				{
					switch (n)
					{
						case 1:
							Console.ForegroundColor = ConsoleColor.Red;
							break;
						case 2:
							Console.ForegroundColor = ConsoleColor.Yellow;
							break;
						case 3:
							Console.ForegroundColor = ConsoleColor.Green;
							break;
					}
					string line = sr.ReadLine();
					for(int k = 0; k < line.Length; k++)
					{
						if (line[k] == '*')
						{
							Console.SetCursorPosition(k, r);
							Console.Write('*');
						}
					}
					r++;
				}
			}
		}
	}
}
