using System;

class FloatingEquality
{
    static void Main()
    {
        double eps = 0.000001;

        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());

        bool areEqual = Math.Abs(a - b) < eps;

        Console.WriteLine(areEqual ? "True" : "False");
    }
}
