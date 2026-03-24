class Magicien : Personnage
{
    private int puissanceMagique;

    public Magicien (string nom, int pointsDeVie, int puissanceMagique)
        :base(nom, pointsDeVie)
    {
        this.puissanceMagique = puissanceMagique;
    }

}