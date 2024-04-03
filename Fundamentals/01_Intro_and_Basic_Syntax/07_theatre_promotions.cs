using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string day = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            int price = 0;

            if (day == "Weekend")
            {
                if ((0 <= age && age <= 18) || (64 < age && age <= 122)) {
                    price = 15;
                }
                else if (18 < age && age <= 64)
                {
                    price = 20;
                }
            }
            else if (day == "Weekday")
            {
                if ((0 <= age && age <= 18) || (64 < age && age <= 122)) {
                    price = 12;
                }
                else if (18 < age && age <= 64)
                {
                    price = 18;
                }
            }
            else if (day == "Holiday")
            {
                if (0 <= age && age <= 18) {
                    price = 5;
                }
                if (18 < age && age <= 64) {
                    price = 12;
                }
                else if (64 < age && age <= 122)
                {
                    price = 10;
                }
            }

            if (price == 0)
            {
                Console.WriteLine("Error!");
            }
            else
            {
                Console.WriteLine(price + "$");
            }
        }
    }
}