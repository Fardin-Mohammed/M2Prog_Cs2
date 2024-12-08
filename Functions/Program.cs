namespace Functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program(); // Maak een nieuw object van de klasse Program.
            program.Run(); // Roep de Run-methode aan om het programma te starten.
        }

        internal void Run() 
        {
            Console.WriteLine("Dit is nu de start van mijn programma"); // eerste tekst
            Vraag1(); // Roep de functie aan

            Console.WriteLine("\nDruk op een toets om af te sluiten...");
            Console.ReadKey(); // Wacht op een toetsdruk voordat het venster sluit
        }


        internal void Vraag1()
        {
            Console.WriteLine("How long do you think you'd survive in a zombie apocalypse?");
            string antwoord = Console.ReadLine();

            Console.WriteLine(antwoord);
        }

        internal void Pizza()
        {
            Console.WriteLine("Why do round pizzas come in square boxes?");
            string antwoord = Console.ReadLine();

            Console.WriteLine(antwoord);
        }

        internal void Childhood()
        {
            Console.WriteLine("If you can still remember, what are your funniest childhood memories?");
            string antwoord = Console.ReadLine();

            Console.WriteLine(antwoord);
        }

        internal void Secret()
        {
            Console.WriteLine("What secret conspiracy would you like to actually start letting other people know?");
            string antwoord = Console.ReadLine();

            Console.WriteLine(antwoord);
        }

        internal void Money()
        {
            Console.WriteLine("What would you do if you won a million dollars?");
            string antwoord = Console.ReadLine();

            Console.WriteLine(antwoord);
        }

        internal void Game()
        {
            Console.WriteLine("What is the worst game you played but that you liked anyway?");
            string antwoord = Console.ReadLine();

            Console.WriteLine(antwoord);
        }
    }
}
