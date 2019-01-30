using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			int[] array = new int[n];
			//fill the array
			for(int k = 0; k < n; k++)
			{
				array[k] = int.Parse(Console.ReadLine());
			}
			int numberOfNotPrime = 0;
			//find the number of prime numbers 
			for(int k = 0; k < n; k++)
			{
				if (array[k] == 1)
				{
					numberOfNotPrime++;
				}
				for(int j = 2; j < array[k]; j++)
				{
					if (array[k] % j == 0)
					{
						numberOfNotPrime++;
						break;
					}
				}
			}
			//Show the number of prime 
			Console.WriteLine(n-numberOfNotPrime);
			//Show the prime numbers usin counter
			int cnt;
			for(int k = 0; k < n; k++)
			{
				cnt = 0;
				if (array[k] < 2)
				{
					cnt++;
				}
				for(int j = 2; j < array[k]; j++)
				{
					if (array[k] % j == 0)
					{
						cnt++;
					}
				}
				
				if (cnt == 0)
				{
					Console.Write(array[k] + " ");
				}
			}
			Console.ReadKey();
		}
	}
}
