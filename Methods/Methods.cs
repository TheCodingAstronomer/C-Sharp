/*
 * Created by SharpDevelop.
 * User: Nihal
 * Date: 17-08-2020
 * Time: 17:59
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Methods
{
	class Program
	{
		public static void Main(string[] args)
		{
			SayHi("Mike", 45);
			SayHi("John", 78);
			SayHi("Tom", 67);
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		static void SayHi (string name, int age) 
		{
			Console.WriteLine("Hello " + name + ", you are " + age + " years old.");
		}
	}
}