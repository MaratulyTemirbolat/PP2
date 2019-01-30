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
			int n = int.Parse(Console.ReadLine()); //Ask to write the number of elements in array
			for(int k = 0; k < n; k++)
			{
				for(int j = 0; j <= k; j++)
				{
					Console.Write("[*]"); //Draw a StarTriangle using cycle
				}
				Console.Write("\n"); // use to begin the drow from the new line
			}
			Console.ReadKey();// ise to show the result until the window did not close
		}
	}
}
