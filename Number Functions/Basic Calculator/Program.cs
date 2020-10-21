/*
 * Created by SharpDevelop.
 * User: Nihal
 * Date: 13-08-2020
 * Time: 20:57
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Basic_Calculator
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.Write("Enter A Number: ");
			
			int num1 = Convert.ToInt32(Console.ReadLine()); //To convert string to int
			
			Console.Write("Enter Another Number: ");
			
			int num2 = Convert.ToInt32(Console.ReadLine());
			
			Console.WriteLine(num1 + num2);
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}