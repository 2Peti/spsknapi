using System;

class Program
{
    static void Main()
    {
        Console.WriteLine(@"This program will find the prime numbers for you. You can choose:
1- just the prime numbers
2- numbers that are not prime numbers
3- both
q- quit");

        while (true)
        {
            string choice = Console.ReadLine();
            if (choice == "q")
                break;

            if (choice == "1" || choice == "2" || choice == "3")
            {
                int upper = int.Parse(Console.ReadLine());

                for (int num = 2; num <= upper; num++)
                {
                    bool isPrime = true;
                    for (int i = 2; i <= Math.Sqrt(num); i++)
                    {
                        if (num % i == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }

                    if (choice == "1" && isPrime)
                    {
                        Console.WriteLine($"{num}, is a prime number");
                    }
                    else if (choice == "2" && !isPrime)
                    {
                        for (int i = 2; i < num; i++)
                        {
                            if (num % i == 0)
                            {
                                Console.WriteLine($"{num} equals {i}*{num / i}");
                                break;
                            }
                        }
                    }
                    else if (choice == "3")
                    {
                        if (isPrime)
                        {
                            Console.WriteLine($"{num}, is a prime number");
