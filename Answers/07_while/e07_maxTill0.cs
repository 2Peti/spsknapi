using System;

class Program
{
    static void Main()
    {
        int n = -1;
        int b = 0;
        while (n != 0)
        {
            n = int.Parse(Console.ReadLine());
            b = Math.Max(n, b);
        }
        Console.WriteLine(b);
    }
}
