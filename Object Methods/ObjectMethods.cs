/*
 * Created by SharpDevelop.
 * User: Nihal
 * Date: 04-08-2020
 * Time: 18:30
 * 
 *
			Console.Write("Press an To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Hello_World_
{
	class Student
	{
		public string name;
		public string major;
		public double gpa;
		public Student(string aName, string aMajor, double Gpa)
		{
			name = aName;
			major = aMajor;
			gpa = Gpa;
		}

		public bool HasHonors()
		{
			if (gpa >= 3.5)
			{
				return true;
			}
			return false;
		}
	}
	
	class Program
	{
		public static void Main(string[] args)
		{
			Student student1 = new Student("Jim", "Business", 2.8);
			Student student2 = new Student("Pam", "Art", 3.6);

			Console.WriteLine(student1.HasHonors());
			Console.WriteLine(student2.HasHonors());
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}