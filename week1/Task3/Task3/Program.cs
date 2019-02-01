using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
	class Program
	{
		static int[] SecArr(int[] arr)
		{
			int[] array = new int[arr.Length * 2];
			int cnt = -1;
			for(int i = 0; i < arr.Length; i++)
			{
				cnt++;
				array[cnt] = arr[i];
				cnt++;
				array[cnt] = arr[i];
			}
			return array;
		}
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			string s = Console.ReadLine();
			string[] arc = s.Split();
			int[] array = new int[n];
			for(int k = 0; k < n; k++)
			{
				array[k] = int.Parse(arc[k]);
			}
			int[] Answ = SecArr(array);
			for(int k = 0; k < Answ.Length; k++)
			{
				Console.Write(Answ[k] + " ");
			}
			Console.ReadKey();
		}
		
	}
}
