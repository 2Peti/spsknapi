using System;

class Program
{
    static void Main()
    {
        string[,] areas = {
            { "residential area", "50" },
            { "outside of residential area", "90" },
            { "highway", "130" }
        };

        Console.WriteLine("You are driving in");
        for (int i = 0; i < areas.GetLength(0); i++)
        {
            Console.WriteLine($"{i + 1}- {areas[i, 0]}");
        }

        int area = int.Parse(Console.ReadLine());
        int speed = int.Parse(Console.ReadLine());

        int limit = int.Parse(areas[area - 1, 1]);

        if (speed < limit - 10)
        {
            Console.WriteLine("you're driving too slow");
        }
        else if (speed <= limit)
        {
            Console.WriteLine("you're driving optimal");
        }
        else if (speed <= limit + 20)
        {
            Console.WriteLine("you're driving too fast");
        }
        else
        {
            Console.WriteLine("you will get a ticket");
        }
    }
}