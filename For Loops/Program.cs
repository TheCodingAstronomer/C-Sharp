/*
 * Created by SharpDevelop.
 * User: Nihal
 * Date: 18-08-2020
 * Time: 17:00
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace For_Loops
{
	class Program
	{
		public static void Main(string[] args)
		{
			int i = 1;
			int[] luckyNums = {4, 8, 16, 32, 64, 128, 256, 512};

			while (i <= 5)
			{
				Console.WriteLine(i);
				i++;
			}
			for (i = 1; i < luckyNums.Length ; i++)
			{
				Console.WriteLine(luckyNums[i]);
			}


			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}