using System;

class TriangleOfNumbers
{

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                if (j < i)
                {
                    Console.Write(i + " ");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }

}
