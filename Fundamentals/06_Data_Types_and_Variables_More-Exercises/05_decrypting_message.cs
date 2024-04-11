using System;

class DecryptingMessages
{
    static void Main()
    {
        int key = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());

        string decryptedMessage = "";

        for (int i = 0; i < n; i++)
        {
            char currentChar = char.Parse(Console.ReadLine());
            decryptedMessage += ((char)((int)currentChar + key)).ToString();
        }

        Console.WriteLine(decryptedMessage);
    }

}
