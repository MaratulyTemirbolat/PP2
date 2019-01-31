using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
	class Student
	{
		public string name;
		public string Id;
		public int YeartOFStudy;
		public Student(string name, string id)
		{
			this.name = name;
			this.Id = id;
		}
		public string GetName()
		{
			return name;
		}
		public string GetId()
		{
			return Id;
		}
		public int GetYearOfStudy()
		{
			return ++YeartOFStudy;
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			Student Info = new Student(Console.ReadLine(), Console.ReadLine());

		}
	}
}
