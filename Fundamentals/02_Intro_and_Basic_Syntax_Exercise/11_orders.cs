using System;

class Orders
{

    static void Main()
    {
        int countOfOrders = int.Parse(Console.ReadLine());

        double totalAmount = 0;

        for (int i = 1; i <= countOfOrders; i++)
        {
            double pricePerCapsule = double.Parse(Console.ReadLine());
            int daysInMonth = int.Parse(Console.ReadLine());
            int capsulesCount = int.Parse(Console.ReadLine());

            double currentAmount = daysInMonth * capsulesCount * pricePerCapsule;
            totalAmount += currentAmount;
            Console.WriteLine($"The price for the coffee is: ${currentAmount:F2}");
        }

        Console.WriteLine($"Total: ${totalAmount:F2}");
    }

}
