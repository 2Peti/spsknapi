using System;

class Program
{
    static void Main()
    {
        int even = 0, odd = 0, over_10 = 0, under_10 = 0;

        while (true)
        {
            string inp = Console.ReadLine();
            if (inp == "q")
                break;

            if (int.TryParse(inp, out int num))
            {
                if (num >= 5 && num <= 25)
                {
                    if (num % 2 == 0)
                        even++;
                    else
                        odd++;

                    if (num > 10)
                        over_10++;
                    if (num < 10)
                        under_10++;
                }
                else
                {
                    Console.WriteLine("The value has to be between 5 and 25.");
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid integer or `q` to quit.");
            }
        }

        Console.WriteLine($"There were:\n{even} even numbers\n{odd} odd numbers\n{under_10} numbers smaller than 10\n{over_10} numbers bigger than 10");
    }
}
