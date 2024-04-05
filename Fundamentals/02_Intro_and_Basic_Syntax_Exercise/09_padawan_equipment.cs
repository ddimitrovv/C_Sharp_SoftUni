using System;

class PadawanEquipment
{

    static void Main()
    {
        double amountOfMoney = double.Parse(Console.ReadLine());
        int students = int.Parse(Console.ReadLine());
        double sabrePrice = double.Parse(Console.ReadLine());
        double robePrice = double.Parse(Console.ReadLine());
        double beltPrice = double.Parse(Console.ReadLine());

        double totalPrice = (sabrePrice * Math.Ceiling(students * 1.1)) + (robePrice * students) + (beltPrice * students - (beltPrice * (int)(students / 6)));

        if (amountOfMoney >= totalPrice)
        {
            Console.WriteLine($"The money is enough - it would cost {totalPrice:F2}lv.");
        }
        else
        {
            Console.WriteLine($"John will need {totalPrice - amountOfMoney:F2}lv more.");
        }
    }

}
