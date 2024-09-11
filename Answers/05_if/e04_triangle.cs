using System;

class Program
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        if (a * a + b * b == c * c)
        {
            Console.WriteLine("right triangle");
        }
        else
        {
            Console.WriteLine("not right triangle");
        }
    }
}
