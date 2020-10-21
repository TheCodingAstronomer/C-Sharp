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
  public Book(string aTitle, string aAuthor, int numOfPages)
  {
  	book1.title = aTitle;
  	book1.author = aAuthor;
  	book1.pages = numOfPages;
  }
}
	class Program
	{
  public static void Main(string[] args)
		{
			Book book1 = new Book("Harry Potter", "J.K. Rowling", 400); //This is a constructor 
			Book book2 = new Book("Lord Of The Rings", "J.R.R. Tolkien", 700);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
}
}