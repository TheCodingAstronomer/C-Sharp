/*
 * Created by SharpDevelop.
 * User: Nihal
 * Date: 11-08-2020
 * Time: 14:47
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace String_Functions
{
	class Program
	{
		public static void Main(string[] args)
		{
			string phrase = "Giraffe Academy";
			
			Console.WriteLine(phrase.Length); //Gives Length
			Console.WriteLine(phrase.ToUpper()); //Turns string to upper case
			Console.WriteLine(phrase.ToLower()); //Turns string to lower case
			Console.WriteLine(phrase.Contains("Academy")); //Checks if given characters are in string given
			Console.WriteLine(phrase[0]); //Goes to char index given
			Console.WriteLine(phrase.IndexOf("Academy")); //Checks where is given string's index located
			Console.WriteLine(phrase.Substring(8)); //Removes characters after given index(Can also replace)

			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}