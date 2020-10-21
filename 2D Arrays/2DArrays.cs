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
			int[,] numberGrid = {
				{1, 2, 3},
				{4, 5, 6},
				{7, 8, 9},
			};
			int[,] myArray = new int[2, 3];

			Console.WriteLine(numberGrid[1, 1]);
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}