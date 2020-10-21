/*
 * Created by SharpDevelop.
 * User: Nihal
 * Date: 13-08-2020
 * Time: 21:41
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
			double num1 = Convert.ToDouble(Console.ReadLine());
			Console.Write("Enter Another Number: ");
			double num2 = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine(num1 + num2);
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}