using System;

class Program
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        if (a > b)
        {
            Console.WriteLine("a is bigger than b");
        }
        else if (b > a)
        {
            Console.WriteLine("b is bigger than a");
        }
        else
        {
            Console.WriteLine("a and b are equal");
        }
    }
}
