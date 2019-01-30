using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());// Write the number of elements in array
			int[] array = new int[n]; // Create the Array with n number
			for(int k = 0; k < n; k++)
			{
				array[k] = int.Parse(Console.ReadLine()); //Fill the Array whith elements
			}
			for(int k = 0; k < n; k++)
			{
				Console.Write(array[k] + " ");//Using cycle Show the elements of array twice
				Console.Write(array[k] + " ");
			}
			Console.ReadKey();
		}
	}
}
