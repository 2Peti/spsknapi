using System;

class Program
{
    static void Main()
    {
        int total = 0;
        for (int i = 1; i <= 100; i++)
        {
            total += i;
        }
        Console.WriteLine(total);

        total = 0;
        int j = 1;
        while (j <= 100)
        {
            total += j;
            j++;
        }
        Console.WriteLine(total);
    }
}
