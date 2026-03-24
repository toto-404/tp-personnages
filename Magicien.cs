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

}