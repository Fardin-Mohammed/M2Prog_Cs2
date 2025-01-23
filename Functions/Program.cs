namespace Functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program(); // Maak een nieuw object van de klasse Program.
            program.Run(); // Roep de Run-methode aan om het programma te starten.
        }

        internal class Program
        {
            string[] vragen = new string[]
            {
                "What 1997 N64 video game, features James Bond and is named after the 1995 film?"
                "What arcade game was called Puckman in Japan?"
            };

            internal string GetVraag(int vraagIndex)
            {
                return vragen[vraagIndex];
                string vraag0 = GetVraag(0);
            }

        }

        internal void Gta5()
        {
            Console.WriteLine("Smoke on the Water is a fictional medical-marijuana shop that can be purchased by Franklin with money gained from completing missions in what heist-y video game franchise?");
            string antwoord = Gta5();

            Console.WriteLine(Gta5();
        }

        internal string GetRandomVraag()
        {
            |
                // gebruik Random
                int random = ...;
            return GetVraag(random);
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

        internal string Vraag7()
        {
            Console.WriteLine("How long do you think you`d survive in a zombie apocalypse?");
            string antwoord7 = Vraag7();
            Console.WriteLine(antwoord7);
            return antwoord; // Geeft het antwoord terug
        }
    }
}
