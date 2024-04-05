using System;

class Messages
{

    static void Main()
    {
        Dictionary<char, string> letters = new()
        {
            { '2', "abc" },
            { '3', "def" },
            { '4', "ghi" },
            { '5', "jkl" },
            { '6', "mno" },
            { '7', "pqrs" },
            { '8', "tuv" },
            { '9', "wxyz" },
            { '0', " " },
        };

        int lettersCount = int.Parse(Console.ReadLine());
        string word = "";

        for (int i = 0; i < lettersCount; i++)
        {
            string input = Console.ReadLine();
            word += letters[input[0]][input.Length - 1];
        }

        Console.WriteLine(word);
    }
}
