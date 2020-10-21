/*
 * Created by SharpDevelop.
 * User: Nihal
 * Date: 18-08-2020
 * Time: 16:48
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Guessing_Game
{
	class Program
	{
		public static void Main(string[] args)
		{
			string secretWord = "giraffe";
			string guess = "";
			int guessNum = 0;
			while(guess != secretWord)
			{
				Console.Write("Enter Guess: ");
				guess = Console.ReadLine();
				if(guessNum == 7)
				{
					Console.WriteLine("Out Of Moves! You Lose!");
					break;
				}
				guessNum++;
			}
			if(guessNum != 7){
				Console.WriteLine("You Win!");
			}
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}