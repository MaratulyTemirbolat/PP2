using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
	class Program
	{
		static void CreatFile()
		{
			StreamWriter sw = new StreamWriter("../../NewFile.txt"); //  Creat the file int the folder below 2 files from the initial path
			sw.WriteLine("Just Words"); //Fill in the file
			sw.Close();// Close File
			//Copy File From the Initial path to another path
			File.Copy(@"C:\Users\ww\Desktop\pp2\week2\Task4\Task4\NewFIle.txt", @"C:\Users\ww\Desktop\pp2\week2\Task4\Task4\FolderForNewFile\NewFile.txt ");
			// Deleted original file 
			File.Delete(@"C:\Users\ww\Desktop\pp2\week2\Task4\Task4\NewFIle.txt");

		}
		static void Main(string[] args)
		{
			CreatFile(); // Call the function 
		}
	}
}
