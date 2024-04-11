using System;

class FromLeftToRight
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string[] values = Console.ReadLine().Split(" ");
            long left = long.Parse(values[0]);
            long right = long.Parse(values[1]);

            long number = left > right ? left : right;

            double sum = SumOfDigits(number);
            Console.WriteLine(sum);
        }
    }

    static long SumOfDigits(long number)
    {
        long sum = 0;
        while (number > 0)
        {
            sum += number % 10;
            number /= 10;
        }
        return sum;
    }
}
