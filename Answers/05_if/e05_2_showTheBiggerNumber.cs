using System;

class Program
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        if (a >= b && a >= c)
        {
            Console.WriteLine("a is bigger than b and c");
        }
        else if (b >= a && b >= c)
        {
            Console.WriteLine("b is bigger than a and c");
        }
        else
        {
            Console.WriteLine("c is bigger than a and b");
        }
    }
}
