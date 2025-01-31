using System;
using System.IO;
using Newtonsoft.Json;

public class Product
{
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
}

public class MagicKaart
{
    public string Naam { get; set; }
    public int Attack { get; set; }
    public int Defense { get; set; }
    public string Beschrijving { get; set; }
}

class Program
{
    static void Main()
    {
        Run();
        RunEigen();
    }

    static void Run()
    {
        string text = File.ReadAllText("Product.json");

        Product[] producten = JsonConvert.DeserializeObject<Product[]>(text);

        foreach (var product in producten)
        {
            Console.WriteLine($"Naam: {product.Name}");
            Console.WriteLine($"Beschrijving: {product.Description}");
            Console.WriteLine($"Prijs: {product.Price:C}\n");
        }
    }

    static void RunEigen()
    {
        string text = File.ReadAllText("MagicKaarten.json");

        MagicKaart[] kaarten = JsonConvert.DeserializeObject<MagicKaart[]>(text);

        foreach (var kaart in kaarten)
        {
            Console.WriteLine($"Naam: {kaart.Naam}");
            Console.WriteLine($"Attack: {kaart.Attack}");
            Console.WriteLine($"Defense: {kaart.Defense}");
            Console.WriteLine($"Beschrijving: {kaart.Beschrijving}\n");
        }
    }
}
