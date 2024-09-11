using System;

class Program
{
    static void Main()
    {
        int max_1_digit = -1;
        int max_2_digit = -1;
        int max_3_digit = -1;

        int num_count = int.Parse(Console.ReadLine());

        for (int i = 0; i < num_count; i++)
        {
            if (int.TryParse(Console.ReadLine(), out int num))
            {
                if (num >= 0 && num <= 9)
                {
                    max_1_digit = Math.Max(max_1_digit, num);
                }
                else if (num >= 10 && num <= 99)
                {
                    max_2_digit = Math.Max(max_2_digit, num);
                }
                else if (num >= 100 && num <= 999)
                {
                    max_3_digit = Math.Max(max_3_digit, num);
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid integer.");
            }
        }

        Console.WriteLine($"Largest 1-digit number: {(max_1_digit != -1 ? max_1_digit.ToString() : "None")}");
        Console.WriteLine($"Largest 2-digit number: {(max_2_digit != -1 ? max_2_digit.ToString() : "None")}");
        Console.WriteLine($"Largest 3-digit number: {(max_3_digit != -1 ? max_3_digit.ToString() : "None")}");
    }
}
