using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= num; i++)
            {
                sum += i * 2 - 1;
                Console.WriteLine("{0}", i * 2 - 1);
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}