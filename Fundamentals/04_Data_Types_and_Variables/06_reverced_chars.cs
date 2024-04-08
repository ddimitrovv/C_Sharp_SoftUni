using System;
using System.Threading.Tasks.Dataflow;

class RevercedChars
{
    static void Main()
    {   
        List<string> stringChars = [];
        for (int i = 1; i <= 3; i++)
        {
            stringChars.Add(Console.ReadLine());
        }

        stringChars.Reverse();
        Console.WriteLine(string.Join(" ", stringChars));
    }

}
