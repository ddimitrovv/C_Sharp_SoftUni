using System;

class Elevator
{
    static void Main()
    {   
        int people = int.Parse(Console.ReadLine());
        int elevatorCapacity = int.Parse(Console.ReadLine());

        int totalCources = 0;

        if (people % elevatorCapacity == 0)
        {
            totalCources = people / elevatorCapacity;
        }
        else
        {
            totalCources = people / elevatorCapacity + 1;
        }
        Console.WriteLine(totalCources);
    }
    
}