class Guerrier : Personnage
{
    private int armure{get;set;}
    public Guerrier(string nom, int PointsDeVie, int armure)
        :base(nom, PointsDeVie)
    {
        this.armure = armure;   
    }

}