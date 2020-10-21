/*
 * Created by SharpDevelop.
 * User: Nihal
 * Date: 17-08-2020
 * Time: 18:17
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Return_Statements
{
	class Program
	{
		public static void Main(string[] args)
		{
			int cubednum = Cube(256);
			
			Console.WriteLine(cubednum);
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		static int Cube(int num)
		{
			int result = num * num * num;
			return result;
		}
	}
}