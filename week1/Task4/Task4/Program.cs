using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine()); // Created the variable n and ask user write it
			string[,] arrayTwo = new string[n, n]; // Created 2Darray with dimensions n*n
			for(int k = 0; k < n; k++)
			{
				for(int j = 0; j < n; j++)
				{
					if (k >= j)  // Condition which works if k more or equal j
					{
						arrayTwo[k, j] = "[*]"; // Write [*] into 2Darray
					}					
				}
			}
			for (int k = 0; k < n; k++)
			{
				for(int j = 0; j < n; j++)
				{
					Console.Write(arrayTwo[k, j]); // Show the elements of the 2Darray
				}
				Console.Write("\n"); // use to begin the drow from the new line
			}
			Console.ReadKey();// use to show the result until the window did not close
		}
	}
}
