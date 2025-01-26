public class Formulier
{
    public string Naam { get; set; }
    public string Review { get; set; }

    public Formulier(string naam, string review)
    {
        Naam = naam;
        Review = review;
    }
}
