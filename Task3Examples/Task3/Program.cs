using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
	class Program
	{
		public static void Ex1()
		{
			FileInfo file = new FileInfo("C:/Users/ww/Desktop/pp2/week2/Task2/Task2");
			Console.WriteLine(file.Name); // название файла
			Console.WriteLine(file.FullName); // Полный до файла
			Console.WriteLine(file.Directory); //Полный путь до попки в которой находится файл
		}
		public static void Ex2()
		{
			DirectoryInfo directory = new DirectoryInfo("C:/Users/ww/Desktop/pp2/week2");
			Console.WriteLine(directory.Name); // Name of the Directory
			Console.WriteLine(directory.FullName); // Full path to this Directory
			Console.WriteLine(directory.Parent); // The name of the directory in which our Directory is located
		}
		public static void Ex3()
		{
			DirectoryInfo dir = new DirectoryInfo("C:/Users/ww/Desktop/Other Things");
			FileInfo[] files = dir.GetFiles(); // Return The array of the files in from dir
			foreach(FileInfo f in files)
			{
				Console.WriteLine(f.Name);// Show Each file in DIrectory
			}
		}
		public static void Ex4()
		{
			DirectoryInfo dir = new DirectoryInfo("C:/Users/ww/Desktop/Other Things");
			DirectoryInfo[] directories = dir.GetDirectories();
			foreach(DirectoryInfo d in directories)
			{
				Console.WriteLine(d.Name);
			}
		}
		
		public static void ShowSpace(int lev)
		{
			for(int k = 0; k < lev; k++)
			{
				Console.Write("		");
			}
		}

		public static void Ex5(DirectoryInfo dir,int level)
		{
			
			foreach(FileInfo d in dir.GetFiles())
			{
				ShowSpace(level);
				Console.WriteLine(d.Name);
			}
			foreach(DirectoryInfo qwe in dir.GetDirectories())
			{
				ShowSpace(level);
				Console.WriteLine(qwe.Name);
				Ex5(qwe, level + 1);
			}
		}
		static void Main(string[] args)
		{
			Ex1();
			Console.WriteLine();
			Ex2();
			Console.WriteLine();
			Ex3();
			Console.WriteLine();
			//Ex4();
			Console.WriteLine();
			Console.WriteLine("All the directories and their file\n\n\n");
			DirectoryInfo dir = new DirectoryInfo("C:/Users/ww/Desktop/Other Things");
			Ex5(dir, 0);
			Console.ReadKey();
		}
	}
}
