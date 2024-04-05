using System;

class GamingStore
{

    static void Main()
    {
        Dictionary<string, double> gamesPriceList = new()
        {
            {"OutFall 4", 39.99},
            {"CS: OG", 15.99},
            {"Zplinter Zell", 19.99},
            {"Honored 2", 59.99},
            {"RoverWatch", 29.99},
            {"RoverWatch Origins Edition", 39.99},
        };

        double currentBalance = double.Parse(Console.ReadLine());
        double spentMoney = 0;

        while (true)
        {
            if (currentBalance == 0)
            {
                Console.WriteLine("Out of money!");
                break;
            }

            string currentGame = Console.ReadLine();

            if (currentGame == "Game Time")
            {
                Console.WriteLine($"Total spent: ${spentMoney:F2}. Remaining: ${currentBalance:F2}");
                break;
            }

            if (gamesPriceList.ContainsKey(currentGame))
            {
                if (currentBalance >= gamesPriceList[currentGame])
                {
                    currentBalance -= gamesPriceList[currentGame];
                    spentMoney += gamesPriceList[currentGame];
                    Console.WriteLine($"Bought {currentGame}");
                }
                else
                {
                    Console.WriteLine("Too Expensive");
                }
            }
            else
            {
                Console.WriteLine("Not Found");
            }

        }
    }
}
