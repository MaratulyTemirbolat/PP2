using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace Ser
{
	public class Hello
	{
		public string Order;
		public string Day;
		public Temer temer;
		public Hello()
		{

		}
		public Hello(string Order,string Day,Temer temer)
		{
			this.Order = Order;
			this.Day = Day;
			this.temer = temer;
		}
		public void Save(Hello h)
		{
			FileStream fs = new FileStream("save.xml", FileMode.Create, FileAccess.Write);
			XmlSerializer xs = new XmlSerializer(typeof(Hello));
			xs.Serialize(fs,h);
			fs.Close();
		}
		public Hello Load()
		{
			FileStream fs = new FileStream("save.xml", FileMode.Open, FileAccess.Read);
			XmlSerializer xs = new XmlSerializer(typeof(Hello));
			Hello h2 = xs.Deserialize(fs) as Hello;
			fs.Close();
			return h2;
		}
	}
	public class Temer
	{
		public string Name;
		public string Surname;
		public int Height;
		public int Year;
		public Temer()
		{

		}
		public Temer(string Name,string Surname,int Height,int Year)
		{
			this.Name = Name;
			this.Surname = Surname;
			this.Height = Height;
			this.Year = Year;
		}
	}
}
