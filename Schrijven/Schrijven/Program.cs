using System;
using System.IO; 
using System.Xml;
using Newtonsoft.Json; 

namespace Schrijven
{
    class Program
    {
        static void Main(string[] args)
        {
            Run();
        }

        static void Run()
        {

            string textToWrite = "Dit is een testbestand!";
            string filePath = "mijntekst.txt";

            File.WriteAllText(filePath, textToWrite);
            Console.WriteLine("Bestand 'mijntekst.txt' is geschreven!");


            string[] lines = { "Lente is gekomen", "Bloemen beginnen te bloeien", "De zon schijnt fel" };
            string linesFilePath = "mijnregels.txt";

            File.WriteAllLines(linesFilePath, lines);
            Console.WriteLine("Bestand 'mijnregels.txt' is geschreven!");


            FavoriteGame[] favoriteGames = {
                new FavoriteGame { Name = "Minecraft", Platform = "PC" },
                new FavoriteGame { Name = "The Witcher 3", Platform = "PC" },
                new FavoriteGame { Name = "FIFA 22", Platform = "PlayStation" }
            };

            string gamesJson = JsonConvert.SerializeObject(favoriteGames, Formatting.Indented);

            File.WriteAllText("games.json", gamesJson);
            Console.WriteLine("Bestand 'games.json' is geschreven!");

            string jsonData = File.ReadAllText("games.json");
            FavoriteGame[] loadedGames = JsonConvert.DeserializeObject<FavoriteGame[]>(jsonData);

            Console.WriteLine("\nGelezen Favorite Games:");
            foreach (var game in loadedGames)
            {
                Console.WriteLine($"Naam: {game.Name}, Platform: {game.Platform}");
            }
        }
    }

    public class FavoriteGame
    {
        public string Name { get; set; }
        public string Platform { get; set; }
    }
}
