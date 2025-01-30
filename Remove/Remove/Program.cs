using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Run();
    }

    static void Run()
    {
        List<double> reviewsList = new List<double>()
        {
            124.50, 98.30, 342.97, 200.45, 176.89
        };

        Console.WriteLine("Reviews (before removal):");
        foreach (double review in reviewsList)
        {
            Console.WriteLine(review);
        }

        reviewsList.Remove(342.97);

        Console.WriteLine("\nReviews (after removing 342.97):");
        foreach (double review in reviewsList)
        {
            Console.WriteLine(review);
        }

        reviewsList.RemoveAt(0);

        Console.WriteLine("\nReviews (after removing first review):");
        foreach (double review in reviewsList)
        {
            Console.WriteLine(review);
        }
    }
}
