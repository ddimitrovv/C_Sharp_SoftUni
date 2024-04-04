using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int multiplier = int.Parse(Console.ReadLine());
            if (multiplier >= 10)
            {
                Console.WriteLine("{0} X {1} = {2}", num, multiplier, multiplier * num);
            }
            else
            {
                for (int i = multiplier; i <= 10; i++)
                {
                    Console.WriteLine("{0} X {1} = {2}", num, i, i * num);
                }
            }
        }
    }
}