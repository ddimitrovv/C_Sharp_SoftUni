using System;

class SpiceMustFlow
{
    static void Main()
    {

        int startingYield = int.Parse(Console.ReadLine());
        int daysWorked = 0;
        int totalAmount = 0;

        while (true)
        {
            if (startingYield < 100)
            {
                totalAmount = Math.Max(totalAmount - 26, 0);
                break;
            }
            daysWorked++;
            totalAmount += startingYield;
            startingYield -= 10;
            totalAmount = Math.Max(totalAmount - 26, 0);
        }
        Console.WriteLine($"{daysWorked}\n{totalAmount}");

    }
}
