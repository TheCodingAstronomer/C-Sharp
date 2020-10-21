/*
 * Created by SharpDevelop.
 * User: Nihal
 * Date: 13-08-2020
 * Time: 20:48
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Getting_User_Input
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.Write("Enter Your Name: ");
			string name = Console.ReadLine();
			Console.Write("Enter Your Age: ");
			string age = Console.ReadLine();
			Console.WriteLine("Hello " + name +", you are  " + age + " years old.");
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}