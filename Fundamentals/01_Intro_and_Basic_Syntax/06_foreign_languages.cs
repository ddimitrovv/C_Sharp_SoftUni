using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string country = Console.ReadLine();
            string language = country switch
            {
                "England" or "USA" => "English",
                "Spain" or "Argentina" or "Mexico" => "Spanish",
                _ => "unknown",
            };
            Console.WriteLine(language);
        }
    }
}