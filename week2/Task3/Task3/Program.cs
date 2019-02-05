using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
	class Program
	{
		public static void ShowSpace(int level)
		{
			for(int k = 0; k < level; k++)
			{
				Console.Write("    ");
			}
		}
		public static void UsingDirc(DirectoryInfo dir,int level)
		{
			
			foreach (FileInfo file in dir.GetFiles())
			{
				ShowSpace(level+1);
				Console.WriteLine(file.Name);
			}
				foreach (DirectoryInfo direct in dir.GetDirectories())
				{
					ShowSpace(level+2);
					Console.WriteLine(direct.Name);
				UsingDirc(direct, level + 3);
				}
		}
		
		static void Main(string[] args)
		{
			DirectoryInfo dir = new DirectoryInfo("C:/Users/ww/Desktop/Other Things");
			Console.WriteLine(dir.Name);
			UsingDirc(dir, 0);
			Console.ReadKey();
		}
	}
}
