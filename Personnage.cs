class Personnage
{
    private protected string nom {get;set;}
    private protected int pointsDeVie{get;set;}
    
    //constuctor
    public Personnage (string nom, int pointsDeVie)
    {
        this.nom = nom;
        this.pointsDeVie = pointsDeVie;
    }
    //methodes
    public int RecevoirDegats(int degats)
    {
        return pointsDeVie -= degats;
    }
    public void Afficher()
    {
        Console.WriteLine($"Nom Personnage: {nom}\nHealth Points: {pointsDeVie}");
    }
}