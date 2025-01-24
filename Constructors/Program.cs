static void Run()
{
    Quiz mijnQuiz = new Quiz(10); // Maak een quiz met 10 vragen

    // Voeg vragen toe met beide methods
    mijnQuiz.VoegVraagToeOpIndex(0, new QuizVraag("Wat is de hoofdstad van Nederland?", "Amsterdam"));
    mijnQuiz.VoegVraagToeOpIndex(1, "Hoeveel provincies heeft Nederland?", "12");
    mijnQuiz.VoegVraagToeOpIndex(2, "Welke kleur heeft de Nederlandse vlag?", "Rood, wit, blauw");
    mijnQuiz.VoegVraagToeOpIndex(3, "Wat is 2 + 2?", "4");
    mijnQuiz.VoegVraagToeOpIndex(4, "Welke dag volgt op vrijdag?", "Zaterdag");
    mijnQuiz.VoegVraagToeOpIndex(5, "Wat is de grootste planeet in ons zonnestelsel?", "Jupiter");
    mijnQuiz.VoegVraagToeOpIndex(6, "Welke taal spreken ze in Spanje?", "Spaans");
    mijnQuiz.VoegVraagToeOpIndex(7, "Hoeveel uur zitten er in een dag?", "24");
    mijnQuiz.VoegVraagToeOpIndex(8, "Wat is het tegenovergestelde van zwart?", "Wit");
    mijnQuiz.VoegVraagToeOpIndex(9, "Wat is de kleinste positieve even getal?", "2");

    // Print de vragen om te testen
    for (int i = 0; i < mijnQuiz.vragen.Length; i++)
    {
        if (mijnQuiz.vragen[i] != null)
        {
            Console.WriteLine($"Vraag {i + 1}: {mijnQuiz.vragen[i].vraag} (Antwoord: {mijnQuiz.vragen[i].antwoord})");
        }
    }
}
