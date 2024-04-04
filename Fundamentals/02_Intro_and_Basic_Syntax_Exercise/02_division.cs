using System;

class Division
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        bool divisible = false;
        foreach (int divisor in new int[] { 10, 7, 6, 3, 2 })
        {
            if (number % divisor == 0)
            {
                Console.WriteLine($"The number is divisible by {divisor}");
                divisible = true;
                break;
            }
        }
        if (!divisible)
        {
            Console.WriteLine("Not divisible");
        }
    }
}