using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
	class Program
	{
		static void Main(string[] args)
		{
			MyThread t1 = new MyThread("Thread 1");
			MyThread t2 = new MyThread("Thread 2");

			t1.startThread();
			t2.startThread();

			Console.Read();
		}
	}
}
