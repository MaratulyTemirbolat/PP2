using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ser
{
	class Program
	{
		static void Main(string[] args)
		{
			Temer t = new Temer("Temirbolat", "Maratuly", 185, 18);
			Hello hello = new Hello("tomato", "29.03.2019", t);
			hello.Save(hello);
			Hello hNew = hello.Load();
			Console.Write(hNew.temer.Surname);
			Console.ReadKey();
		}
	}
}
