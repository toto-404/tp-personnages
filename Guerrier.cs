class Guerrier : Personnage
{
    private int armure{get;set;}
    public Guerrier(string nom, int PointsDeVie, int armure)
        :base(nom, PointsDeVie)
    {
        this.armure = armure;   
    }

    //accès methodes avec virtual/overide

    public override void Afficher()
    {
        //base.Afficher();
        Console.WriteLine($"Guerrier: {nom}\nHealth Points: {pointsDeVie}\nArmure: {armure}");
    }

}