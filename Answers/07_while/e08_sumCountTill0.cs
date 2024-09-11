using System;

class Program
{
    static void Main()
    {
        int n = -1;
        int s = 0;
        while (n != 0)
        {
            n = int.Parse(Console.ReadLine());
            s += n;
        }
        Console.WriteLine(s);
    }
}
