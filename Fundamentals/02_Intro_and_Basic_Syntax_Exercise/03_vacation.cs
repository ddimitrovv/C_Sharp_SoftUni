using System;

class Vacation
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        string type = Console.ReadLine();
        string day = Console.ReadLine();

        double totalAmount = 0;
        double ticketPrice = 0;

        switch (type)
        {
            case "Students":
                ticketPrice = day switch
                {
                    "Friday" => 8.45,
                    "Saturday" => 9.80,
                    "Sunday" => 10.46,
                };
                totalAmount = ticketPrice * number;
                if (number >= 30)
                {
                    totalAmount *= 0.85;
                }
                break;

            case "Business":
                ticketPrice = day switch
                {
                    "Friday" => 10.90,
                    "Saturday" => 15.60,
                    "Sunday" => 16,
                };
                totalAmount = ticketPrice * number;
                if (number >= 100)
                {
                    totalAmount -= ticketPrice * 10;
                }
                break;

            case "Regular":
                ticketPrice = day switch
                {
                    "Friday" => 15,
                    "Saturday" => 20,
                    "Sunday" => 22.50,
                };
                totalAmount = ticketPrice * number;
                if (number >= 10 && number <= 20)
                {
                    totalAmount *= 0.95;
                }
                break;
        }
        Console.WriteLine($"Total price: {totalAmount:F2}");
    }
}

