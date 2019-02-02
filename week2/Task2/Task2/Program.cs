using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
	class Program
	{
		static void IsPrime()
		{
			StreamReader sr = new StreamReader("../../input.txt");
			StreamWriter sw = new StreamWriter("../../output.txt");
			string s = sr.ReadLine();
			string[] ar = s.Split();
			
			for(int k = 0; k < ar.Length; k++)
			{
				int a = int.Parse(ar[k]);
				bool Check = true;
				if (a == 1)
				{
					Check = false;
				}
				for (int j = 2; j < a; j++)
				{
					if (a % j == 0)
					{
						Check = false;
					}
				}
				if (Check == true)
				{
					sw.Write(a + " ");
				}
			}
			sr.Close();
			sw.Close();
			
		}
		static void Main(string[] args)
		{
			IsPrime();
			Console.ReadKey();
		}
	}
}
