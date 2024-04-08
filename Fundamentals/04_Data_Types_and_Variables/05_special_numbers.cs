using System;

class RevercedChars
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            int sumOfDigits = CalculateSumOfDigits(i);
            bool isSpecial = sumOfDigits == 5 || sumOfDigits == 7 || sumOfDigits == 11;
            Console.WriteLine($"{i} -> {isSpecial}");
        }
    }

    static int CalculateSumOfDigits(int number)
    {
        int sum = 0;
        while (number != 0)
        {
            sum += number % 10;
            number /= 10;
        }
        return sum;
    }
}
