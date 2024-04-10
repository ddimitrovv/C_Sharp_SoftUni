using System;

class BeerKegs
{
    static void Main()
    {
        string maxModel = "";
        double maxVolume = double.MinValue;

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string model = Console.ReadLine();
            double radius = double.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            double volume = Math.PI * Math.Pow(radius, 2) * height;
            if (volume > maxVolume)
            {
                maxModel = model;
                maxVolume = volume;
            }
        }

        Console.WriteLine(maxModel);
    }
}
