using System;

class StrongNumber
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        long totalSum = 0;
        foreach (var numStr in number.ToString())
        {
            totalSum += Factorial(int.Parse(numStr.ToString()));
        }

        if (totalSum == number)
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
    }

    static long Factorial(int n)
    {
        if (n == 0)
            return 1;
        return n * Factorial(n - 1);
    }
}
