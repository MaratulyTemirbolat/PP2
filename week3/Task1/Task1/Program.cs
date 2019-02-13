using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task1
{
	class FarManager
	{
		DirectoryInfo dir = null;
		public int cursor;
		public string path;
		public int size;
		FileSystemInfo f1 = null;
		public FarManager()
		{

		}
		public FarManager(string path)
		{
			this.path = path;
			cursor = 0;
		}
		public void Color(FileSystemInfo f, int index)
		{
			if (cursor == index)
			{
				Console.BackgroundColor = ConsoleColor.Cyan;
				Console.ForegroundColor = ConsoleColor.Black;
				f1 = f;
			}
			else if (f.GetType() == typeof(DirectoryInfo))
			{
				Console.BackgroundColor = ConsoleColor.White;
				Console.ForegroundColor = ConsoleColor.Blue;
			}
			else
			{
				Console.BackgroundColor = ConsoleColor.White;
				Console.ForegroundColor = ConsoleColor.Red;
			}
		}
		public void Show()
		{

			dir = new DirectoryInfo(path);
			FileSystemInfo[] FSI = dir.GetFileSystemInfos();
			Console.BackgroundColor = ConsoleColor.White;
			Console.Clear();
			for (int k = 0, j = 0; k < FSI.Length; k++)
			{
				if (FSI[k].Name[0] == '.')
					continue;
				Color(FSI[k], j);
				Console.WriteLine(j + 1 + ". " + FSI[k].Name);
				j++;
			}

		}
		public void CalSize()
		{
			DirectoryInfo d = new DirectoryInfo(path);
			FileSystemInfo[] fi = d.GetFileSystemInfos();
			size = fi.Length;
			for (int k = 0; k < fi.Length; k++)
			{
				if (fi[k].Name[0] == '.')
					size--;
			}
		}
		public void Down()
		{
			cursor++;
			if (cursor == size)
				cursor = 0;
		}
		public void Up()
		{
			cursor--;
			if (cursor < 0)
				cursor = size - 1;
		}
		public void Start()
		{

			ConsoleKeyInfo Cons;

			while (true)
			{
				CalSize();
				Show();
				Cons = Console.ReadKey();
				Console.Clear();
				if (Cons.Key == ConsoleKey.DownArrow)
				{
					Down();
				}
				else if (Cons.Key == ConsoleKey.UpArrow)
				{
					Up();
				}
				else if (Cons.Key == ConsoleKey.Enter)
				{
					if (f1.GetType() == typeof(DirectoryInfo))
					{
						cursor = 0;
						path = f1.FullName;
					}
					else
					{
						StreamReader SR = new StreamReader(f1.FullName);
						Console.WriteLine(SR.ReadToEnd());
						SR.Close();
						Console.ReadKey();
						Console.Clear();

					}
				}
				else if (Cons.Key == ConsoleKey.Tab)
				{
					if (dir.Parent.FullName != @"C:\")
					{
						path = dir.Parent.FullName;
						cursor = 0;
						Console.Clear();
					}
					else
					{
						Console.WriteLine("You Can't go out from the disk");
						Console.ReadKey();
						Console.Clear();
					}
				}
				else if (Cons.Key == ConsoleKey.Backspace)
				{
					if (f1.GetType() == typeof(DirectoryInfo))
					{
						cursor = 0;
						Directory.Delete(f1.FullName);
					}
					else
					{
						cursor = 0;
						File.Delete(f1.FullName);
					}
				}
				else if (Cons.Key == ConsoleKey.Escape)
				{
					Console.Clear();
					string name = Console.ReadLine();
					Console.Clear();
					string copPath = Path.Combine(dir.FullName, name);
					if (f1.GetType() == typeof(DirectoryInfo))
					{
						Directory.Move(f1.FullName, copPath);
					}
					else
					{
						File.Move(f1.FullName, copPath);
					}
				}
			}
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			string path = @"C:\Users\ww\Downloads";
			FarManager FM = new FarManager(path);
			FM.Start();
		}
	}
}