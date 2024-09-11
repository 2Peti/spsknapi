using System;

class Program
{
    static void Main()
    {
        Console.WriteLine(string.Join(", ", System.Linq.Enumerable.Range(10, 45).Where(i => i % 2 == 0)));
    }
}
