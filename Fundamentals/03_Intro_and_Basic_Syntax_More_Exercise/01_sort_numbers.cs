using System;

class SortNumbers
{

    static void Main()
    {
        List<int> numbers = [];

        for (int i = 1; i <= 3; i++)
        {
            numbers.Add(int.Parse(Console.ReadLine()));
        }

        numbers.Sort();

        for (int i = numbers.Count - 1; i >= 0; i--)
        {
            Console.WriteLine(numbers[i]);
        }
    }

}
