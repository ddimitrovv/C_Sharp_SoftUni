using System;

class PokeMon
{
    static void Main()
    {
        int power = int.Parse(Console.ReadLine());
        int distance = int.Parse(Console.ReadLine());
        int exhaustionFactor = int.Parse(Console.ReadLine());

        int totalTargets = 0;
        int currentPower = power; 
        while (currentPower >= distance)
        {
            currentPower -= distance;
            totalTargets++;
            if (power == 2 * currentPower && currentPower / exhaustionFactor > 0)
            {
                currentPower /= exhaustionFactor;
            }
        }

        Console.WriteLine($"{currentPower}\n{totalTargets}");
    }
}
