using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
	class Program
	{
		static bool IsPrime(int number) // Created bool function which will return true or false
		{
			if (number == 1) // if the number equal 1 The function will return false
				return false;
			for(int k = 2; k < number; k++) // Cycle from 2 to number
			{
				if (number % k == 0) // Condition which returns false If the number when dividing by the remainder is zero
					return false;
			}
			return true; // returns true if the previus conditions does not perform
		}
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine()); // Created the variable n which is the amount of numbers in array
			string s = Console.ReadLine();
			string[] ar = s.Split(); // Array in which every element is the number from s devided by space
			int[] array = new int[n]; // The array with n numbers
			for(int k = 0; k < n; k++)
			{
				array[k] = int.Parse(ar[k]); // Record every value from ar into int  to array
			}
			int cnt = 0; // Counter for calculating prime numbers
			for(int k = 0; k < n; k++)
			{
				if (IsPrime(array[k]) == true) // The condition Which is performed if the Function  returns true 
				{
					cnt++; // Counting prime numbers
				}
			}
			Console.WriteLine(cnt); // Show the total amount of prime numbers 
			for(int k = 0; k < n; k++)
			{
				if (IsPrime(array[k]) == true) // Condition which comes into if the function returns true when the number is prime
					Console.Write(array[k] + " "); // Show the prime number
			}
			Console.ReadKey();
		}
		
	}
}
