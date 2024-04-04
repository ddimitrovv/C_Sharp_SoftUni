using System;

class Login
{
    static void Main()
    {
        string username = Console.ReadLine();
        string correctPassword = ReverseString(username);
        int counter = 0;

        while (true)
        {
            string password = Console.ReadLine();

            if (correctPassword == password)
            {
                Console.WriteLine($"User {username} logged in.");
                break;
            }
            else
            {
                counter++;
                if (counter == 4)
                {
                    Console.WriteLine($"User {username} blocked!");
                    break;
                }
                Console.WriteLine("Incorrect password. Try again.");
            }
        }

        static string ReverseString( string s )
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        
    }
}