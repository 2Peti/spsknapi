using System;

class Program
{
    static void Main()
    {
        int start = int.Parse(Console.ReadLine());
        int product = 1;
        for (int i = start; i < start + 7; i++)
        {
            product *= i;
        }
        Console.WriteLine(product);

        start = int.Parse(Console.ReadLine());
        product = 1;
        int j = start;
        while (j < start + 7)
        {
            product *= j;
            j++;
        }
        Console.WriteLine(product);
    }
}
