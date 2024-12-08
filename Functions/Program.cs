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
            Console.WriteLine("Dit is nu de start van mijn programma");
        }
    }
}
