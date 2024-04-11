using System;

class DataTypeFinder
{
    static void Main()
    {
        while (true)
        {
            string input = Console.ReadLine();

            if (input == "END")
            {
                break;
            }

            string dataType;

            if (int.TryParse(input, out _))
            {
                dataType = "integer";
            }
            else if (double.TryParse(input, out _))
            {
                dataType = "floating point";
            }
            else if (char.TryParse(input, out _))
            {
                dataType = "character";
            }
            else if (bool.TryParse(input, out _))
            {
                dataType = "boolean";
            }
            else
            {
                dataType = "string";
            }
            Console.WriteLine($"{input} is {dataType} type");
        }
    }
}
