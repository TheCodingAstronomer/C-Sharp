/*
 * Created by SharpDevelop.
 * User: Nihal
 * Date: 14-08-2020
 * Time: 14:10
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Arrays
{
	class Program
	{
		public static void Main(string[] args)
		{
			int[] luckyNums = {1, 2, 4, 8, 16, 32, 64, 128, 256, 512};
			string[] friends = new string[60]; //To give the array a limited number of elements
			int[] people = new int[3];
			people[2] = 3456655;
			
			Console.WriteLine(luckyNums[0]);
			luckyNums[0] = 90909;
			Console.WriteLine(luckyNums[0]);
			Console.WriteLine(people[2]);
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}