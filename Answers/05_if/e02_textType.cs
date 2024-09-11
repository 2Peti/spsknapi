using System;

class Program
{
    static void Main()
    {
        string text = Console.ReadLine();

        if (text.All(char.IsLower))
        {
            Console.WriteLine("Text je malými písmenami.");
        }
        else if (text.All(char.IsUpper))
        {
            Console.WriteLine("Text je veľkými písmenami.");
        }
        else if (text.All(char.IsDigit))
        {
            Console.WriteLine("Text je číslo.");
        }
        else
        {
            Console.WriteLine("Text nie je ani malými písmenami, veľkými písmenami, ani číslo.");
        }
    }
}