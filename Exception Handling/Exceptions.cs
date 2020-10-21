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
	class Program
	{
		public static void Main(string[] args)
		{
			int num1;
			int num2;

			try 
			{
				Console.Write("Enter a number: ");
				num1 = Convert.ToInt32(Console.ReadLine());
				Console.Write("Enter another number: ");
				num2 = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine(num1 / num2);
			}
			catch (DivideByZeroException e)
			{
				Console.WriteLine(e.Message);
			}
			catch (FormatException e)
			{
				Console.WriteLine(e.Message);
			}
			/*finally To always excecute a line of code no matter what
			{

			}*/
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}