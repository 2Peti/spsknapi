using System;

class Program
{
    static void Main()
    {
        int R1 = int.Parse(Console.ReadLine());
        int R2 = int.Parse(Console.ReadLine());

        Console.WriteLine($"Výsledný odpor pri sériovom zapojení je: {R1 + R2}");
        Console.WriteLine($"Výsledný odpor pri paralelnom zapojení je: {(R1 * R2) / (double)(R1 + R2)}");
    }
}
