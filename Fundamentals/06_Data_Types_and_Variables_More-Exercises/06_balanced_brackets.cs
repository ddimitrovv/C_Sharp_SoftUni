using System;

class BalancedBrackets
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Stack<char> stack = new();

        for (int i = 0; i < n; i++)
        {
            string input = Console.ReadLine().Trim();

            if (input == "(")
            {
                stack.Push('(');
            }
            else if (input == ")")
            {
                if (stack.Count == 0 || stack.Peek() != '(')
                {
                    Console.WriteLine("UNBALANCED");
                    return;
                }
                stack.Pop();
            }
        }

        Console.WriteLine(stack.Count == 0 ? "BALANCED" : "UNBALANCED");
    }

}
