using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Task1
{
	class Program
	{
		
		static void Main(string[] args)
		{
			Thread[] threads = new Thread[3];
			for(int k = 0,j=0; k < 3; k++)
			{
				++j;
				threads[k] = new Thread(CurN);
				threads[k].Name = j.ToString();
				threads[k].Start();
			}
			Console.ReadKey();
		}
		static void CurN()
		{
			Object obj = new object();
			lock (obj)
			{
				for (int k = 0; k < 3; k++)
					Console.Write("Thread number "+Thread.CurrentThread.Name + '\n');
			}
		}
	}
}
