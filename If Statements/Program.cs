/*
 * Created by SharpDevelop.
 * User: Nihal
 * Date: 17-08-2020
 * Time: 18:26
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace If_Statements
{
	class Program
	{
		public static void Main(string[] args)
		{
			bool isMale = true;
			bool isTall = true;
			
			if(isMale || isTall){
				Console.WriteLine("You are either male or tall");
			} else if (isMale && isTall) {
				Console.WriteLine("You are a tall male");
			} else if (!isMale && isTall){
				Console.WriteLine("You are a tall female");
			} else if (isMale && !isTall ){
				Console.WriteLine("You are a short male");
			}
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}