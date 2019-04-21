using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace Rima_sSeril
{
	class Program
	{
		static void Main(string[] args)
		{
			Person p1 = new Person("Tobi", 20, "Italy");
			Person p2 = new Person("Rima", 22, "Tokyo");
			Person p3 = new Person("Saske", 21, "Korea");
			Team t1 = new Team("Obito",p1);
			Team t2 = new Team("Madara", p2);
			t1.players.Add(p1);
			t1.players.Add(p2);
			t2.players.Add(p1);
			t2.players.Add(p3);
			Football fot = new Football(t1, t2, "Dinamo", p3);
			fot.Ser();
			fot.Des();
			

		}
	}
	public class Football
	{
		public Team firstTeam;
		public Team secondTeam;
		public string stadium;
		public Person reference;
		public Football()
		{

		}
		public Football(Team firstTeam,Team secondTeam,string stadium,Person reference)
		{
			this.firstTeam = firstTeam;
			this.secondTeam = secondTeam;
			this.stadium = stadium;
			this.reference = reference;
		}
		public void Ser()
		{
			FileStream fs = new FileStream("save.xml", FileMode.Create, FileAccess.Write);
			XmlSerializer xs = new XmlSerializer(typeof(Football));
			xs.Serialize(fs, this);
			fs.Close();
		}
		public Football Des()
		{
			FileStream fs = new FileStream("save.xml", FileMode.Open, FileAccess.Read);
			XmlSerializer xs = new XmlSerializer(typeof(Football));
			Football f2 = xs.Deserialize(fs) as Football;
			fs.Close();
			return f2;
		}
	}
	public class Team
	{
		public List<Person> players;
		public string name;
		public Person coach;
		public Team()
		{

		}
		public Team(string name,Person coach)
		{
			players = new List<Person>();
		}
	}
	public class Person
	{
		public string name;
		public int age;
		public string country;
		public Person()
		{

		}
		public Person(string name,int age,string country)
		{
			this.name = name;
			this.age = age;
			this.country = country;
		}
	}
}
