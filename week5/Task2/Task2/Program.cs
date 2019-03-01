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
			Mark m1 = new Mark(65);
			Mark m2 = new Mark(70);
			Mark m3 = new Mark(91);
			List<Mark> Lis = new List<Mark>() { m1, m2, m3 };
			Mark.Ser(Lis);
			List<Mark> Lis2 = Mark.Des();
			foreach(Mark m in Lis2)
			{
				Console.WriteLine(m);
			}
			Console.ReadKey();
		}
	}
}
