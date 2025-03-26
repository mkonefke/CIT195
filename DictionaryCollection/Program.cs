using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<int, string> movieShowings = new Dictionary<int, string>();

        movieShowings.Add(1, "Snow White and the Seven Dwarves");
        movieShowings.Add(2, "Mufasa: The Lion King");
        movieShowings.Add(3, "Sonic the Hedgehog 3");
        movieShowings.Add(4, "Joker 2");
        movieShowings.Add(5, "Anora");

        Console.WriteLine("Theatre Number:");
        foreach (var key in movieShowings.Keys)
        {
            Console.WriteLine(key);
        }

        Console.WriteLine("Movie:");
        foreach (var value in movieShowings.Values)
        {
            Console.WriteLine(value);
        }

        Console.WriteLine("Movies and theatre number:");
        foreach (var entry in movieShowings)
        {
            Console.WriteLine($"Theatre Number: {entry.Key}, Movie: {entry.Value}");
        }

        movieShowings.Remove(4);
        Console.WriteLine("Item removed from dictionary.");

        Console.WriteLine($"Items left in dictionary: {movieShowings.Count}");
    }
}