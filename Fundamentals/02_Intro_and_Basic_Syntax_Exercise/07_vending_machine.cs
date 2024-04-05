using System;
using System.Collections.Generic;

class VendingMachine
{

    static void Main()
    {
        double[] numbers = [0.1, 0.2, 0.5, 1, 2];
        string[] products = ["Nuts", "Water", "Crisps", "Soda", "Coke"];
        Dictionary<string, double> productPricelist = new()
        {
            {"Nuts", 2.0},
            {"Water", 0.7},
            {"Crisps", 1.5},
            {"Soda", 0.8},
            {"Coke", 1.0},
        };
        double totalAmount = 0;

        while (true)
        {
            string money = Console.ReadLine();
            if (money == "Start")
                break;
            double currentAmount = double.Parse(money);
            if (Array.Exists(numbers, x => x == currentAmount))
            {
                totalAmount += currentAmount;
            }
            else
            {
                Console.WriteLine($"Cannot accept {money}");
            }    

        }

        while (true)
        {
            string currentPurchase = Console.ReadLine();
            if (currentPurchase == "End")
            {
                Console.WriteLine($"Change: {totalAmount:F2}");
                break;
            }
            if (!Array.Exists(products, p => p == currentPurchase))
            {
                Console.WriteLine("Invalid product");
            }
            else
                if (totalAmount - productPricelist[currentPurchase] < 0)
                {
                    Console.WriteLine("Sorry, not enough money");
                }
                else
                {
                    totalAmount -= productPricelist[currentPurchase];
                    Console.WriteLine($"Purchased {currentPurchase.ToLower()}");
                }
        }

    }

}
