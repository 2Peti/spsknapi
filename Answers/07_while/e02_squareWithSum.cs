using System;

class Program
{
    static void Main()
    {
        int i = 1;
        int total = 0;
        while (i <= 10)
        {
            int square = i * i;
            Console.WriteLine($"{i} druhá mocnina {square}");
            total += square;
            i++;
        }
        Console.WriteLine("---------------");
        Console.WriteLine($"Ich súčet: {total}");
    }
}
