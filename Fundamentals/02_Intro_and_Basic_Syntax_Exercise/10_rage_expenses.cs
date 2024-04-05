using System;

class RageExpences
{

    static void Main()
    {
        int lostGamesCount = int.Parse(Console.ReadLine());
        double headsetPrice = double.Parse(Console.ReadLine());
        double mousePrice = double.Parse(Console.ReadLine());
        double keyboardPrice = double.Parse(Console.ReadLine());
        double monitorPrice = double.Parse(Console.ReadLine());

        double expenses = 0;

        for (int i = 1; i <= lostGamesCount; i++)
        {
            if (i % 2 == 0)
            {
                expenses += headsetPrice;
            }
            if (i % 3 == 0)
            {
                expenses += mousePrice;
            }
            if (i % 6 == 0)
            {
                expenses += keyboardPrice;
            }
            if (i % 12 == 0)
            {
                expenses += monitorPrice;
            }
        }

        Console.WriteLine($"Rage expenses: {expenses:F2} lv.");
    }

}
