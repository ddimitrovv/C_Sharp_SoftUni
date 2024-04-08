using System;

class CharsToString
{
    static void Main()
    {   
        string result = "";
        for (int i = 1; i <= 3; i++)
        {
            result += Console.ReadLine();
        }

        Console.WriteLine(result);
    }

}
