using System;

class Program
{
    static void Main()
    {
        int lower = int.Parse(Console.ReadLine());
        int upper = int.Parse(Console.ReadLine());
        int total = 0;

        for (int i = lower; i <= upper; i++)
        {
            if (i % 2 == 0)
            {
                total += i;
            }
        }
        Console.WriteLine(total);

        lower = int.Parse(Console.ReadLine());
        upper = int.Parse(Console.ReadLine());
        total = 0;
        int j = lower;

        while (j <= upper)
        {
            if (j % 2 == 0)
            {
                total += j;
            }
            j++;
        }
        Console.WriteLine(total);
    }
}
