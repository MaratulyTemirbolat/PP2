using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;


namespace Task2
{
	public class Mark
	{
		
		public int points;
		public List<Data> datas;
		public Data just;
		
		public Mark()
		{

		}
		public  Mark(int points,Data just)
		{
			this.just = just;
			datas = new List<Data>();
			this.points = points;
		}
		public char GetLetter(char Let)
		{
			return Let;
		}
		public void Des(Mark Ma)
		{
			FileStream fil = new FileStream("FileForSer.xml", FileMode.Open, FileAccess.Read);
			XmlSerializer xs = new XmlSerializer(typeof(Mark));
			Ma = xs.Deserialize(fil) as Mark;
			Console.WriteLine(datas[0].name);
			fil.Close();
		}
	}
	public class Data
	{
		public string name;
		public int Year;
		public int growth;
		public Data() { }
		public Data(string name,int Year,int growth)
		{
			this.name = name;
			this.Year = Year;
			this.growth = growth;
		}
		public override string ToString()
		{
			return "Name: " + name + "\nYear: " + Year;
		}
	}
}
