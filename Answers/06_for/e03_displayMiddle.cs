using System;

class Program
{
    static void Main()
    {
        Console.Write("Give odd number between <5,11>: ");
        if (int.TryParse(Console.ReadLine(), out int num) && num >= 5 && num <= 11 && num % 2 == 1)
        {
            string stars = new string('*', (num - 1) / 2);
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine($"{stars}I{stars}");
            }
        }
        else
        {
            Console.WriteLine("not a good number");
        }
    }
}
