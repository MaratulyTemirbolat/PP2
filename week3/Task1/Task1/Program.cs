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
		public FarManager() // Empty Constructor
		{

		}
		public FarManager(string path) // Constructor which obtain path and Write it down into original path
		{
			this.path = path; 
			cursor = 0;
		}
		public void Color(FileSystemInfo f, int index) // Method Which Drow different colors for console
		{
			if (cursor == index) // Condition which works if the Cursor is equal to the index of the array
			{
				Console.BackgroundColor = ConsoleColor.Cyan;
				Console.ForegroundColor = ConsoleColor.Black;
				f1 = f; // Assign the f to F1 to use it Globally
			}
			else if (f.GetType() == typeof(DirectoryInfo)) // Condition which paints console and name if it is A folder
			{
				Console.BackgroundColor = ConsoleColor.White;
				Console.ForegroundColor = ConsoleColor.Blue;
			}
			else // Otherwise if it is a File
			{
				Console.BackgroundColor = ConsoleColor.White;
				Console.ForegroundColor = ConsoleColor.Red;
			}
		}
		public void Show() // Method Show for presenting everything into my directory
		{

			dir = new DirectoryInfo(path); // Assign the path to the Dir
			FileSystemInfo[] FSI = dir.GetFileSystemInfos(); // Get all the Info about files and write into array
			Console.BackgroundColor = ConsoleColor.White; // Paint the Console intp White color every time
			Console.Clear();
			for (int k = 0, j = 0; k < FSI.Length; k++) // Cycle for showing everything
			{
				if (FSI[k].Name[0] == '.') // If the file is Hidden do not show it
					continue;
				Color(FSI[k], j); // Call the function to Paint all interface
				Console.WriteLine(j + 1 + ". " + FSI[k].Name); // Show the index of the File and its name
				j++;
			}

		}
		public void CalSize() // Method fo calculating size of the array without Hidden files
		{
			DirectoryInfo d = new DirectoryInfo(path); // Create the Direcotory With and send the path
			FileSystemInfo[] fi = d.GetFileSystemInfos(); // Create The array and Write the array of all the files from Directory
			size = fi.Length; // size = The number of all elements into array
			for (int k = 0; k < fi.Length; k++) // Cycle for recalculating the size of the array 
			{
				if (fi[k].Name[0] == '.') // If the Name of the File starts with '.' size mines 1
					size--;
			}
		}
		public void Down() // The method for go down
		{
			cursor++; 
			if (cursor == size) // if the Cursor is equal the last element of the array after Click go to the beginning
				cursor = 0;
		}
		public void Up()
		{
			cursor--;
			if (cursor < 0) // If the cursor is equal less then 0-th we go the end of the array
				cursor = size - 1;
		}
		public void Start() //The main function
		{

			ConsoleKeyInfo Cons; 
			bool Ok = true; // Bool function Ok to use for going out
			while (Ok==true) //Cycle works until Ok is true
			{
				CalSize(); // Calculate the size of the array without Hidden files
				Show(); // Show all the Elements into array using method Show
				Cons = Console.ReadKey(); //Click the buttom to do something
				if (Cons.Key == ConsoleKey.DownArrow) // if the buttom is DownArrow call the method DOwn
				{
					Down();
				}
				else if (Cons.Key == ConsoleKey.Spacebar) // if the buttom is Spacebar Go out from the cycle and end the work
				{
					Ok = false;
				}
				else if (Cons.Key == ConsoleKey.UpArrow) // if the buttom is UpArrow call the method Up and cursor go UP
				{
					Up();
				}
				else if (Cons.Key == ConsoleKey.Enter) // If the buttom is Enter The programm open the File or Folder
				{
					if (f1.GetType() == typeof(DirectoryInfo)) // Checking for type
					{
						cursor = 0;
						path = f1.FullName; // Path is equal the Full path of this Folder
					}
					else
					{
						StreamReader SR = new StreamReader(f1.FullName); 
						Console.WriteLine(SR.ReadToEnd());// Show everything into the file 
						SR.Close(); // DO NOT FORGET TO CLOSE 
						Console.ReadKey(); 
						Console.Clear();

					}
				}
				else if (Cons.Key == ConsoleKey.Escape) // If the Buttom is equal Escape We go back into one step
				{
					if (dir.Parent.FullName != @"C:\") // We can go back before the disk
					{
						path = dir.Parent.FullName; // Update our path
						cursor = 0;						
					}
					else
					{
						Console.Clear();
						Console.WriteLine("You Can't go out from the disk"); // Ii we go to the last folder after Clicking the buttom Escape Show that we Can't go back next
						Console.ReadKey();			
					}
				}
				else if (Cons.Key == ConsoleKey.Backspace) // IF the Buttom is equal to the Backspace DELETE the Fileor the Folder
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
				else if (Cons.Key == ConsoleKey.Tab) // if the buttom is equal Tab Rename the File or Folder
				{
					Console.Clear();
					string name = Console.ReadLine(); // Write the new Name for the File or Folder
					Console.Clear();
					string copPath = Path.Combine(dir.FullName, name); // Create the new Path using new Name
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
			string path = @"C:\Users\ww\Downloads"; // Path to my Directory
			FarManager FM = new FarManager(path); 
			FM.Start(); // Call the Function start
		}
	}
}