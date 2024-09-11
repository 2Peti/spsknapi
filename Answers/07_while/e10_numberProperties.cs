using System;

class Program
{
    static void Main()
    {
        int div_10 = 0, div_3 = 0, over_50 = 0, under_50 = 0;
        int total_sum = 0, count = 0;

        while (true)
        {
            string inp = Console.ReadLine();
            if (inp == "q")
                break;

            if (int.TryParse(inp, out int num))
            {
                total_sum += num;
                count++;

                if (num % 10 == 0)
                    div_10++;
                if (num % 3 == 0)
                    div_3++;
                if (num > 50)
                    over_50++;
                else if (num < 50)
                    under_50++;
            }
            else
            {
                Console.WriteLine("Please enter a valid integer or `q` to quit.");
            }
        }

        double avg = count > 0 ? (double)total_sum / count : 0;

        Console.WriteLine($"Numbers divisible by 10: {div_10}");
        Console.WriteLine($"Numbers divisible by 3: {div_3}");
        Console.WriteLine($"Numbers greater than 50: {over_50}");
        Console.WriteLine($"Numbers less than 50: {under_50}");
        Console.WriteLine($"Average: {avg:F2}");
    }
}
