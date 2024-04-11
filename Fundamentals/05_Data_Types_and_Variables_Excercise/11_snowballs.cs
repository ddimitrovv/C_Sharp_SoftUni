using System;

class Snowballs
{
    static void Main()
    {
        Dictionary<string, double> snowballRecord = new()
        {
            { "snowballSnow", 0 },
            { "snowballTime", 0 },
            { "snowballQuality", 0 },
            { "snowballValue", double.MinValue }
        };

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            int snowballSnow = int.Parse(Console.ReadLine());
            int snowballTime = int.Parse(Console.ReadLine());
            int snowballQuality = int.Parse(Console.ReadLine());
            double currentValue = Math.Pow(snowballSnow / snowballTime, snowballQuality);
            if (snowballRecord["snowballValue"] <= currentValue)
            {
                snowballRecord["snowballSnow"] = snowballSnow;
                snowballRecord["snowballTime"] = snowballTime;
                snowballRecord["snowballQuality"] = snowballQuality;
                snowballRecord["snowballValue"] = currentValue;
            };
        }

        Console.WriteLine
        (
            $"{snowballRecord["snowballSnow"]} : {snowballRecord["snowballTime"]} = {snowballRecord["snowballValue"]} ({snowballRecord["snowballQuality"]})"
        );
    }
}
