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

namespace GettersAndSetters
{
	class Movie
	{
		private string title;
		private string director;
		private string rating;
		public Movie(string aTitle, string aName, string aRating)
		{
			title = aTitle;
			director = aName;
			Rating = aRating;
		}
		public string Rating
		{
			get{return rating;}
			set
			{
				if(value == "G" || value == "PG" || value == "PG-13" ||value == "R" || value == "NR")
				{
					rating = value;
				}
				else
				{
					rating = "NR";
				}
			}
		}
	}
	class Program
	{
		public static void Main(string[] args)
		{
			Movie avengers = new Movie("The Avengers", "Joss Wheden", "Dog");
			Movie shrek = new Movie("Shrek", "Adam Adamson", "PG");
			//G,PG,PG-13,R,NR

			Console.WriteLine(avengers.Rating);
			Console.WriteLine(shrek.Rating);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}