using System;

class SortNumbers
{

    static void Main()
    {
        Dictionary<char, string> numbersSpelling = new()
        {
            {'0', "zero"},
            {'1', "one"},
            {'2', "two"},
            {'3', "three"},
            {'4', "four"},
            {'5', "five"},
            {'6', "six"},
            {'7', "seven"},
            {'8', "eight"},
            {'9', "nine"},
        };

        Console.WriteLine(numbersSpelling[Console.ReadLine()[^1]]);
    }

}
