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

namespace Book
{
	class Book
{
  public string title;
  public string author;
  public int pages;
}
	class Program
	{
  public static void Main(string[] args)
		{
			Book book1 = new Book(name);
			book1.title = "Harry Potter";
			book1.author = "J.K. Rowling";
			book1.pages = 400;

			Book book2 = new Book();
			book2.title = "Lord Of The Rings";
			book2.author = "J.R.R. Tolkien";
			book2.pages = 700;

			Console.WriteLine(book2.pages);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
}
}