using System;

class RefactoringPrimeChecker
{
    static void Main()
    {
        int end = int.Parse(Console.ReadLine());
        for (int i = 2; i <= end; i++)
        {
            bool isPrime = true;
            for (int number = 2; number < i; number++)
            {
                if (i % number == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            Console.WriteLine($"{i} -> {isPrime.ToString().ToLower()}");
        }
    }

}
