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
		public Student(string name, string id) // Constructor which will take two parameters
		{
			this.name = name; 
			this.Id = id;
		}
		public string GetName() // The Method which returns name of the Student
		{
			return name;
		}
		public string GetId() // The Method which returns ID of the Student
		{
			return Id;
		}
		public int GetYearOfStudy()  // The Method which increases Year of the Student
		{
			return ++YeartOFStudy;
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			Student Info = new Student(Console.ReadLine(), Console.ReadLine());
			Console.WriteLine(Info.GetName()); // Call The function GetName to access the Name and Show it
			Console.WriteLine(Info.GetId()); // Call the function GetID to access the Id of the Student and Show it
			Console.WriteLine(Info.GetYearOfStudy()); // Call the Functon GetYearOfStudy to increase the year of the study
			Console.ReadKey();
		}
	}
}
