class Archer : Personnage
{
    private int precision{get; set;}
    public Archer (string nom, int pointsDeVie, int precision)
    :base(nom, pointsDeVie)
    {
        this.precision = precision;   
    }

    public void Tirer()
    {
        Console.WriteLine($"L'archer {nom} tire une flèche avec une précision {precision}");
    }
}