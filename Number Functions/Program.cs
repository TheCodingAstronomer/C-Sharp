/*
 * Created by SharpDevelop.
 * User: Nihal
 * Date: 14-08-2020
 * Time: 13:58
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Mad_Libs
{
	class Program
	{
		public static void Main(string[] args)
		{
			string colour, pluralNoun, celebrity;
			
			Console.Write("Enter a colour: ");
			colour = Console.ReadLine();
			Console.Write("Enter a plural noun: ");
			pluralNoun = Console.ReadLine();
			Console.Write("Enter a celebrity: ");
			celebrity = Console.ReadLine();
			Console.WriteLine("Roses are " + colour);
			Console.WriteLine(pluralNoun + " are blue");
			Console.WriteLine("I Love " + celebrity);
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}