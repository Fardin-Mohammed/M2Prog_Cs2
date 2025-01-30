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

        List<Pickup> pickups = new List<Pickup>();

        for (int i = 0; i < 5; i++)
        {
            pickups.Add(new Pickup($"Pickup {i + 1}", i + 1));
        }

        Console.WriteLine("Alle pickups:");
        foreach (var pickup in pickups)
        {
            Console.WriteLine($"{pickup.Name} met waarde {pickup.Value}");
        }

        for (int i = pickups.Count - 1; i >= 0; i--)
        {
            if (pickups[i].Value % 2 == 0)
            {
                Console.WriteLine($"Oppakken: {pickups[i].Name} met waarde {pickups[i].Value}");
                pickups.RemoveAt(i);
            }
        }

        Console.WriteLine("\nOvergebleven pickups:");
        foreach (var pickup in pickups)
        {
            Console.WriteLine($"{pickup.Name} met waarde {pickup.Value}");
        }
    }
}

class Pickup
{
    public string Name { get; set; }
    public int Value { get; set; }

    public Pickup(string name, int value)
    {
        Name = name;
        Value = value;
    }
}
