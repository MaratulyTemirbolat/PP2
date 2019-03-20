using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Task1
{
	class Program
	{
	 static int j = 1;
		static void Main(string[] args)
		{ 
			Thread[] threads = new Thread[3];
			Object obj = new Object();
			 
			for(int k = 0; k < 3; k++)
			{
				 threads[k] = new Thread(GotTheName);
				threads[k].Name = j.ToString();
				threads[k].Start();
				
				
			}
			Console.ReadKey();
		}
		static void GotTheName()
		{
			Object lockObject = new Object();
			lock (lockObject)
			{
				for (int k = 0; k < 3; k++)
				{
					Console.WriteLine(Thread.CurrentThread.Name);
				}
				j++;
			}
		}
	}
}
