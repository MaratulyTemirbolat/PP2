using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace Task1
{
	public class Complex
	{
		public int a;
		public int b;
	    public Complex()
		{
		}
		public Complex(int a,int b)
		{
			this.a = a;
			this.b = b;
		}
		public override string ToString()
		{
			return a + " + " + b + "i";
		}
		 public  void Ser(Complex a)
		{
			FileStream fs = new FileStream("fileForSer.xml", FileMode.Create, FileAccess.Write);
			XmlSerializer xs = new XmlSerializer(typeof(Complex));
			xs.Serialize(fs, a);
			fs.Close();
		}
		public Complex Des()
		{
			FileStream fs = new FileStream("fileForSer.xml", FileMode.Open, FileAccess.Read);
			XmlSerializer xs = new XmlSerializer(typeof(Complex));
			Complex C = xs.Deserialize(fs) as Complex;
			fs.Close();
			return C;
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			Complex com = new Complex(5,6);
			com.Ser(com);
			Complex a = com.Des();
			Console.WriteLine(a);
			Console.ReadKey();
		}
	}
}
