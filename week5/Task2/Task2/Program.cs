using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace Task2
{
	
	class Program
	{
		static void Main(string[] args)
		{
			Data LOL = new Data();
			LOL.name = "Hello";
			LOL.growth = 170;
			LOL.Year = 15;
			Mark m = new Mark(95,LOL);
			Console.WriteLine(LOL);
			Data d1 = new Data("Temir", 18, 184);
			Data d2 = new Data("Assanali", 17, 174);
			m.datas.Add(d1);
			m.datas.Add(d2);
			Console.WriteLine(m.GetLetter('A'));
			FileStream fs = new FileStream("FileForSer.xml", FileMode.Truncate, FileAccess.ReadWrite);
			XmlSerializer xs = new XmlSerializer(typeof(Mark));
			xs.Serialize(fs, m);
			fs.Close();
			m.Des(m);
			

			Console.ReadKey();
		}
	}
}
