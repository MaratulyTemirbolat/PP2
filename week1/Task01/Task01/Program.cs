using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
	class Program
	{
		static bool IsPrime(int number)
		{
			if (number == 1)
				return false;
			for(int k = 2; k < number; k++)
			{
				if (number % k == 0)
					return false;
			}
			return true;
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
			int cnt = 0;
			for(int k = 0; k < n; k++)
			{
				if (IsPrime(array[k]) == true)
				{
					cnt++;
				}
			}
			Console.WriteLine(cnt);
			for(int k = 0; k < n; k++)
			{
				if (IsPrime(array[k]) == true)
					Console.Write(array[k] + " ");
			}
			Console.ReadKey();
		}
		
	}
}
