using System;

class WaterOverflow
{
    static void Main()
    {   
        int tankCapacity = 255;
        int tankCurrentFill = 0;
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            int currentWater = int.Parse(Console.ReadLine());
            if (currentWater + tankCurrentFill <= tankCapacity)
            {
                tankCurrentFill += currentWater;
            }
            else
            {
                Console.WriteLine("Insufficient capacity!");
            }
        }
        Console.WriteLine(tankCurrentFill);
    }
    
}