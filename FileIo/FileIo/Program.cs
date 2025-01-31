using System;
using System.IO;

class Program
{
    static void Main()
    {
        Run();
    }

    static void Run()
    {
        string welkomstTekst = "hello world";  // Standaard welkomsttekst
        string saveFile = "welkomState.txt";   // Bestand om de tekst op te slaan

        // Check of het bestand bestaat en lees het in
        if (File.Exists(saveFile))
        {
            welkomstTekst = File.ReadAllText(saveFile);  // Lees de tekst uit het bestand
        }

        // While-loop die de welkomsttekst blijft tonen en de gebruiker vraagt om een nieuwe tekst
        while (true)
        {
            // Toon de huidige welkomsttekst
            Console.WriteLine(welkomstTekst);
            Console.WriteLine("Voer een nieuwe welkomsttekst in (druk 'exit' om te stoppen):");

            // Lees de nieuwe welkomsttekst van de gebruiker
            string input = Console.ReadLine();

            // Stop de loop als de gebruiker 'exit' invoert
            if (input.ToLower() == "exit")
            {
                break;
            }

            // Zet de nieuwe tekst als de welkomsttekst
            welkomstTekst = input;

            // Sla de nieuwe tekst op in het bestand
            File.WriteAllText(saveFile, welkomstTekst);
        }

        // Beëindig het programma met een bericht
        Console.WriteLine("Programma afgesloten.");
    }
}
