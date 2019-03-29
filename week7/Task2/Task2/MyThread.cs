using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Task2
{
	class MyThread
	{
		Thread threadField;
		public MyThread(string name)
		{
			threadField = new Thread(Show);
			threadField.Name = name;
		
		}
		public void startThread()
		{
			threadField.Start();
		}
		public void Show()
		{
			for (int k = 1; k <= 4; k++)
			{
				Console.Write(Thread.CurrentThread.Name + " выводит " + k + '\n');
				if (k == 4)
					Console.Write(Thread.CurrentThread.Name + " завершился" + '\n');
			}
	}
	}
}
