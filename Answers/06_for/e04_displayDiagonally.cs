using System;

class Program
{
    static void Main()
    {
        Console.Write("Give odd number between <5,11>: ");
        if (int.TryParse(Console.ReadLine(), out int n) && n % 2 == 1 && n >= 5 && n <= 11)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"{new string('*', i)}I{new string('*', n - i - 1)}");
            }
        }
        else
        {
            Console.WriteLine("not good number");
        }
    }
}
