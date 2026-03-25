class Magicien : Personnage
{
    private int puissanceMagique;

    public Magicien (string nom, int pointsDeVie, int puissanceMagique)
        :base(nom, pointsDeVie)
    {
        this.puissanceMagique = puissanceMagique;
    }

    //override

    public override void Afficher()
    {
        // base.Afficher();
        Console.WriteLine($"Magicien: {nom}\nHealth Points: {pointsDeVie}\nPuissance MAgique: {puissanceMagique}");
    }
 //p6 méthodes spécifiques

    public void LancerSort()
    {
        Console.WriteLine($"Le magicien {nom} lance un sort");
    }

    public override string ToString()
    {
        return $"{base.ToString()}\nPuissance Magique: {puissanceMagique}";
    }
}