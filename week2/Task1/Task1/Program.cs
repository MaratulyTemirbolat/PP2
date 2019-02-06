using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
	class Program
	{
		static void Do()
		{
			StreamReader sr = new StreamReader("input'.txt"); 
			string s = sr.ReadToEnd(); // Create string to Write Down the word from the beginning to the end  from the "input" file into s
			bool Check = true; // Create bool for cheching 
			for(int k = 0; k < s.Length; k++) 
			{
				if (s[k] != s[s.Length - 1 - k])// Condition which comes into if k-th element of the word is not equal s.Length - 1-k
					Check = false;
			}
			if (Check == true) // Condition Which Shows Yes if Chech is equal true in the end
				Console.Write("Yes");
			else
			{
				Console.Write("No"); // Show NO if Check is equal false
			}
			sr.Close(); // Do not foreget to close the project
		}
		static void Main(string[] args)
		{
			Do(); // Call the function to check for palindrom
			Console.ReadKey();
		}
	}
}
