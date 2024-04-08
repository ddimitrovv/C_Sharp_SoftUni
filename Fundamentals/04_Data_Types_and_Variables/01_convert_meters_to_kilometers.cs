using System;

class ConvertMetersToKilimeters
{

    static void Main()
    {
        int meters = int.Parse(Console.ReadLine());
        double kilometers = (double)meters / 1000;
        Console.WriteLine($"{kilometers:F2}");
    }
}
