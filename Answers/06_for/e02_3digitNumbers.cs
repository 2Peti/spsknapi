using System;

class Program
{
    static void Main()
    {
        Console.WriteLine(string.Join(", ", System.Linq.Enumerable.Range(0, (1000 - 105) / 14 + 1).Select(i => 105 + i * 14)));
    }
}
