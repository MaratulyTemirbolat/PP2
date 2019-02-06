using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1Additional
{
	class Program
	{
		static bool IsPrime(int number) // The bool function which takes the number and returns True Or False
		{
			if (number == 0 || number==1) //  The condition Which returns false  if the number is equal 0 or 1 
				return false;
			else
			{
				for(int k = 2; k < number; k++) // Cycle Which runs from 2 to the number-1
				{
					if (number % k == 0) // Condition Which  Stops cycle and returns false if number is devided by equal 0
					{
						return false;
					}
				}
				return true; // Return true 
			}
		}
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine()); 
			int[] array = new int[n]; // Create an array with n elements
			int cnt = 0; // Counter to calculate the number of Prime Numbers
			for(int k = 0; k < n; k++)
			{
				array[k] = int.Parse(Console.ReadLine()); // Write each element of the array
				if (IsPrime(array[k]) == true) // Condition in Which we call the function with each number of the array and increase the counter if it returns true
				{
					cnt++; // Increase the counter
				}
			}
			Console.WriteLine(cnt); // Show the amount of Prime Numbers
			for(int k = 0; k < n; k++) 
			{
				if (IsPrime(array[k]) == true) // Condition in which we call the function with each number of the array and Show this element if it returns true
				{
					Console.Write(array[k] + " "); 
				}
			}
			Console.ReadKey();
		}
	}
}
