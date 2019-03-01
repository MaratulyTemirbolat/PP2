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
		public int point;
	
		public Mark()
		{
		}
		public Mark(int point)
		{
			this.point = point;
		}
		public string getLetter()
		{
			if (point >= 95)
				return "A";
			if (point >= 90)
				return "A-";
			if (point >= 85)
				return "B+";
			if (point >= 80)
				return "B";
			if (point >= 75)
				return "B-";
			if (point >= 70)
				return "C+";
			if (point >= 65)
				return "C";
			if (point >= 60)
				return "C-";
			if (point >= 55)
				return "D+";
			if (point >= 50)
				return "D";
			return "F";
		}
		public override string ToString()
		{
			return "The point is: " + point + " The Mark is: " + getLetter();
		}
		public static void Ser(List<Mark> m)
		{
			FileStream fs = new FileStream("FileForSerial.xml", FileMode.OpenOrCreate, FileAccess.Write);
			XmlSerializer xs = new XmlSerializer(typeof(List<Mark>));
			xs.Serialize(fs,m);
			fs.Close();
		}
		public static List<Mark> Des()
		{
			FileStream fs = new FileStream("FileForSerial.xml", FileMode.Open, FileAccess.Read);
			XmlSerializer xs = new XmlSerializer(typeof(List<Mark>));
			List<Mark> M = xs.Deserialize(fs) as List<Mark>;
			return M;
			fs.Close();
		}
	}
}
