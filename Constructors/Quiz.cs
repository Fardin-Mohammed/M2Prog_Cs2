internal class Quiz
{
    internal string titel;
    internal QuizVraag[] vragen;
    internal QuizVraagAntwoord[] ingevuldeAntwoorden;

    // Constructor met argument
    internal Quiz(int aantalVragen)
    {
        vragen = new QuizVraag[aantalVragen]; // Maak een array van QuizVraag met de grootte van aantalVragen
        ingevuldeAntwoorden = new QuizVraagAntwoord[aantalVragen]; // Maak een array voor antwoorden
    }

    // Function: Voeg een vraag toe op een specifieke index
    internal void VoegVraagToeOpIndex(int index, QuizVraag vraag)
    {
        if (index >= 0 && index < vragen.Length)
        {
            vragen[index] = vraag;
        }
        else
        {
            Console.WriteLine("Index buiten bereik!");
        }
    }

    // Overloaded function: Voeg een vraag toe met een string vraag en antwoord
    internal void VoegVraagToeOpIndex(int index, string vraag, string antwoord)
    {
        QuizVraag nieuweVraag = new QuizVraag(vraag, antwoord);
        VoegVraagToeOpIndex(index, nieuweVraag); // Gebruik de eerste functie
    }
}
