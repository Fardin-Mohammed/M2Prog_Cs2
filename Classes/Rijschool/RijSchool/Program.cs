namespace RijSchool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.run();  // Roept de run functie aan
        }

        // Niet-statische Run-function
        public void run()
        {
            Console.WriteLine("Dit is nu de start van mijn programma");
        }


    }
}
