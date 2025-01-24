internal class QuizVraagAntwoord
{
    internal string vraag;
    internal string gegevenAntwoord;
    internal bool isCorrect;

    // Constructor met argumenten
    internal QuizVraagAntwoord(string vraag, string gegevenAntwoord, bool isCorrect)
    {
        this.vraag = vraag;
        this.gegevenAntwoord = gegevenAntwoord;
        this.isCorrect = isCorrect;
    }
}
