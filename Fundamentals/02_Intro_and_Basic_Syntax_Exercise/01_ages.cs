using System;

class Ages
{
    static void Main()
    {
        int age = int.Parse(Console.ReadLine());
        string personIs = age switch
        {
            int n when (0 <= n && n <= 2) => "baby",
            int n when (3 <= n && n <= 13) => "child",
            int n when (13 < n && n <= 19) => "teenager",
            int n when (20 <= n && n <= 65) => "adult",
            int n when (n > 65) => "elder",
        };
        Console.WriteLine(personIs);
    }
}
