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
			Console.WriteLine(GetPow(3, 2));
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}

		static int GetPow(int baseNum, int powNum)
		{
			int result = 1;

			for (int i = 0; i < powNum; i++)
			{
				result = result * baseNum;
			}

			return result;
		}
	}
}