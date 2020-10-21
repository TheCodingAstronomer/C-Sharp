using System;

namespace StringFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            string phrase = "Giraffe Academy";
            Console.WriteLine(phrase.Length);
            Console.WriteLine(phrase.Contains('A'));
            Console.WriteLine(phrase.Insert(5 , "Nihal"));
            Console.WriteLine(phrase.ToLower());
            Console.WriteLine(phrase.ToUpper());
            Console.WriteLine(phrase.Substring(8 , 5));
            Console.WriteLine(phrase.Substring(8));
            Console.WriteLine(phrase.IndexOf('A'));
            Console.WriteLine(phrase[8]);
            Console.WriteLine("Giraffe\nAcademy");
            Console.WriteLine("Giraffe\"Academy");
        }
    }
}
