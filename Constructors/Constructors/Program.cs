using System;

class Program
{
    static void Main(string[] args)
    {
        Run();
    }

    static void Run()
    {
        QuizVraag vraag1 = new QuizVraag("Wat is de hoofdstad van Nederland?", "Amsterdam");
        Console.WriteLine($"Vraag: {vraag1.vraag}");
        Console.WriteLine($"Antwoord: {vraag1.antwoord}");
    }
}
