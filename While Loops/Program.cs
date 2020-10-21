/*
 * Created by SharpDevelop.
 * User: Nihal
 * Date: 18-08-2020
 * Time: 16:40
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace While_Loops
{
	class Program
	{
		public static void Main(string[] args)
		{
			int index = 6;
			
			/*while(index <= 5)
			{
				Console.WriteLine(index);
				index++;
			}*/
			
			do
			{
				Console.WriteLine(index);
				index++;
			}while(index <= 5);
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}