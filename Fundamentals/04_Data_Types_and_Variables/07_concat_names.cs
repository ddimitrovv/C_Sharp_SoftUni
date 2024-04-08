using System;

class ConcatNames
{
    static void Main()
    {   
        List<string> stringChars = [];
        for (int i = 1; i <= 3; i++)
        {
            stringChars.Add(Console.ReadLine());
        }

        Console.WriteLine(stringChars[0] + stringChars[^1] + stringChars[1]);
    }

}
