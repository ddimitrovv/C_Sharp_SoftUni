using System;

class LowerOrUpper
{
    static void Main()
    {   
        Console.WriteLine(char.IsUpper(char.Parse(Console.ReadLine())) ? "upper-case" : "lower-case");
    }

}
