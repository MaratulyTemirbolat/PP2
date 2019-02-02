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
			string s = sr.ReadToEnd();
			bool Check = true;
			for(int k = 0; k < s.Length; k++)
			{
				if (s[k] != s[s.Length - 1 - k])
					Check = false;
			}
			if (Check == true)
				Console.Write("Yes");
			else
			{
				Console.Write("No");
			}
			sr.Close();
		}
		static void Main(string[] args)
		{
			Do();
			Console.ReadKey();
		}
	}
}
