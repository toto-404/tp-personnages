namespace tp_personnages;

class Program
{
    static void Main(string[] args)
    {
        Personnage p1 = new Personnage("Hulk", 800);
        p1.RecevoirDegats(50);
        p1.Afficher();
    }

    //guerrier

    Guerrier g1 = new Guerrier("Gurrier", 600, 100);


    //Magicien
    Magicien m1 = new Magicien("Roku le magicien", 500, 300);
}
